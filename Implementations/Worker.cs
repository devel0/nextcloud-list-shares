namespace SearchAThing.NextCloudUtils;

public sealed class Worker : BackgroundService
{
    readonly CloudContext dbContext;
    readonly IHostApplicationLifetime hostLifetime;
    readonly IConfiguration configuration;

    public Worker(
        IServiceProvider serviceProvider
    )
    {
        var scope = serviceProvider.CreateScope();
        var sp = scope.ServiceProvider;

        dbContext = sp.GetRequiredService<CloudContext>();
        hostLifetime = sp.GetRequiredService<IHostApplicationLifetime>();
        configuration = sp.GetRequiredService<IConfiguration>();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var outputPathfilename = configuration.GetValue<string>("output");

        if (Environment.GetCommandLineArgs().Any(w => w == "--help"))
        {
            Console.WriteLine($"{Assembly.GetExecutingAssembly().GetName().Name} [-o outputPathfilename.xlsx] [--help]");
            hostLifetime.StopApplication();
            return;
        }

        var users = dbContext.OcUsers.ToList();

        var shares = dbContext.OcShares.ToList();

        var q = shares
            .GroupBy(w => new { w.FileSource, w.FileTarget })
            .ToList()
            .Select(shareGrp => new
            {
                shareGrp.Key.FileSource,
                shareGrp.Key.FileTarget,
                FullPath = dbContext.OcFilecaches.FirstOrDefault(r => r.Fileid == shareGrp.First().FileSource)?.Path ?? "",
                ShareModes = shareGrp.Select(share => new
                {
                    ShareType = ShareTypeToString(share.ShareType),
                    share.ShareWith,
                    PermissionsStr = PermissionsToString(share.Permissions),
                    share.Permissions,
                    share.UidInitiator
                })
                .Distinct()
                .ToList()
            })
            .Where(qnfo => qnfo.FullPath.StartsWith("files/"))
            .ToList();

        // flatten

        var q2 = q
            .SelectMany(uu => uu.ShareModes.Select(u => new
            {
                uu.FileSource,
                uu.FileTarget,
                uu.FullPath,
                u.Permissions,
                u.UidInitiator,
                u.PermissionsStr,
                u.ShareType,
                u.ShareWith
            }));

        // merge permissions for same ShareWith

        short MergePermissions(IEnumerable<short> perms)
        {
            short res = 0;

            foreach (var p in perms) res |= p;

            return res;
        }

        var q3 = q2
            .GroupBy(t => new { t.FullPath, t.ShareWith, t.UidInitiator })
            .Select(g => new
            {
                g.Key.FullPath,
                g.Key.ShareWith,
                g.Key.UidInitiator,
                MaxPermissions = MergePermissions(g.Select(r => r.Permissions)),
                PermissionsStr = PermissionsToString(MergePermissions(g.Select(r => r.Permissions))),
                shareTypes = g.Select(r => r.ShareType).ToList()
            })
            .OrderBy(w => w.shareTypes.FirstOrDefault() == "group" ? "0" + w.ShareWith : "1" + w.ShareWith).ThenBy(w => w.FullPath);

        var wb = new XLWorkbook();
        var ws = wb.AddWorksheet("Shares");
        IXLCell cell;
        var r = 1;
        var c = 1;

        void setCell(string text, bool? center = null, XLColor? color = null)
        {
            cell = ws.Cell(r, c);
            cell.Value = text;
            if (center is not null) cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            if (color is not null) cell.Style.Font.SetFontColor(color);
        }

        void setCellBold(string text)
        {
            setCell(text);
            cell.Style.Font.SetBold();
        }

        setCellBold("Link"); var colLink = c++;
        setCellBold("User / [Group]"); var colUser = c++;
        setCellBold("READ"); var colREAD = c++;
        setCellBold("UPDATE"); var colUPDATE = c++;
        setCellBold("CREATE"); var colCREATE = c++;
        setCellBold("DELETE"); var colDELETE = c++;
        setCellBold("SHARE"); var colSHARE = c++;
        setCellBold("Path"); var colPath = c++;
        setCellBold("SharedBy"); var colSharedBy = c++;
        setCellBold("ShareType"); var colShareType = c++;

        ++r;

        var LINK_COLOR = XLColor.FromHtml("#004c4e");
        var PERM_READ_COLOR = XLColor.Green;
        var PERM_UPDATE_COLOR = XLColor.Orange;
        var PERM_CREATE_COLOR = XLColor.Blue;
        var PERM_DELETE_COLOR = XLColor.Red;
        var PERM_SHARE_COLOR = XLColor.Magenta;

        var emailPathfilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "email.png");

        foreach (var y in q3)
        {
            var path = y.FullPath.StripBegin("files/");

            Console.WriteLine($"{path}");

            Console.WriteLine($"  {string.Join(", ", y.shareTypes)} {y.ShareWith} {y.PermissionsStr} SBY:[{y.UidInitiator}]");

            var isLink = y.shareTypes.Count == 1 && y.shareTypes[0] == "link";
            var isEmailLink = y.shareTypes.Count == 1 && y.shareTypes[0] == "email";

            if (isLink || isEmailLink)
            {
                c = colLink;
                setCell("■", center: true, color: LINK_COLOR);
            }

            c = colPath; setCell(path, color: isLink ? LINK_COLOR : null);

            if (y.shareTypes.Count == 1 && y.shareTypes[0] == "group")
            {
                c = colUser; setCell($"[{y.ShareWith ?? ""}]");
            }
            else
            {
                c = colUser; setCell(y.ShareWith ?? "");
            }

            if ((y.MaxPermissions & 1) == 1)
            {
                c = colREAD;
                setCell("■", center: true, color: PERM_READ_COLOR);
            }

            if ((y.MaxPermissions & 2) == 2)
            {
                c = colUPDATE;
                setCell("■", center: true, color: PERM_UPDATE_COLOR);
            }

            if ((y.MaxPermissions & 4) == 4)
            {
                c = colCREATE;
                setCell("■", center: true, color: PERM_CREATE_COLOR);
            }

            if ((y.MaxPermissions & 8) == 8)
            {
                c = colDELETE;
                setCell("■", center: true, color: PERM_DELETE_COLOR);
            }

            if ((y.MaxPermissions & 16) == 16)
            {
                c = colSHARE;
                setCell("■", center: true, color: PERM_SHARE_COLOR);
            }

            c = colSharedBy;
            setCell(y.UidInitiator ?? "");

            c = colShareType;
            setCell(string.Join(',', y.shareTypes));

            ++r;
        }

        ws.FinalizeWorksheet();

        if (outputPathfilename is null)
            outputPathfilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "shares.xlsx");

        wb.SaveAs(outputPathfilename);

        hostLifetime.StopApplication();
    }


    string PermissionsToString(short permissions)
    {
        var shareType = new HashSet<string>();

        if ((permissions & 1) == 1)
            shareType.Add("READ");

        if ((permissions & 2) == 2)
            shareType.Add("UPDATE");

        if ((permissions & 4) == 4)
            shareType.Add("CREATE");

        if ((permissions & 8) == 8)
            shareType.Add("DELETE");

        if ((permissions & 16) == 16)
            shareType.Add("SHARE");

        return string.Join(",", shareType);
    }

    string ShareTypeToString(short shareType) => shareType switch
    {
        0 => "user",
        1 => "group",
        2 => "usergroup",
        3 => "link",
        4 => "email",
        5 => "contact",
        6 => "remote",
        7 => "circle",
        8 => "guest",
        9 => "remote group",
        10 => "room",
        11 => "userroom",
        12 => "deck",
        13 => "deckuser",
        _ => "unknown"
    };
}