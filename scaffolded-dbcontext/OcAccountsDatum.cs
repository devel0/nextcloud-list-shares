using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcAccountsDatum
{
    public long Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
