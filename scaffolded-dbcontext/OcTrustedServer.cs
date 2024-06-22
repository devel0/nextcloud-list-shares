using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTrustedServer
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public string UrlHash { get; set; } = null!;

    public string? Token { get; set; }

    public string? SharedSecret { get; set; }

    public int Status { get; set; }

    public string? SyncToken { get; set; }
}
