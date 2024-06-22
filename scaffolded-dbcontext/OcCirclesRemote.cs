using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesRemote
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int Interface { get; set; }

    public string? Uid { get; set; }

    public string? Instance { get; set; }

    public string? Href { get; set; }

    public string? Item { get; set; }

    public DateTime? Creation { get; set; }
}
