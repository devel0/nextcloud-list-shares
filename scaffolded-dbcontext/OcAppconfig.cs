using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcAppconfig
{
    public string Appid { get; set; } = null!;

    public string Configkey { get; set; } = null!;

    public string? Configvalue { get; set; }

    public int Type { get; set; }

    public short Lazy { get; set; }
}
