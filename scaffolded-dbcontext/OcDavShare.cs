using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcDavShare
{
    public long Id { get; set; }

    public string? Principaluri { get; set; }

    public string? Type { get; set; }

    public short? Access { get; set; }

    public long Resourceid { get; set; }

    public string? Publicuri { get; set; }
}
