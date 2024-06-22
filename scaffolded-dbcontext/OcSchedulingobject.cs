using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcSchedulingobject
{
    public long Id { get; set; }

    public string? Principaluri { get; set; }

    public byte[]? Calendardata { get; set; }

    public string? Uri { get; set; }

    public int? Lastmodified { get; set; }

    public string? Etag { get; set; }

    public long Size { get; set; }
}
