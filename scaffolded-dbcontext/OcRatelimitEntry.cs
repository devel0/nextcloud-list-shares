using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcRatelimitEntry
{
    public long Id { get; set; }

    public string Hash { get; set; } = null!;

    public DateTime DeleteAfter { get; set; }
}
