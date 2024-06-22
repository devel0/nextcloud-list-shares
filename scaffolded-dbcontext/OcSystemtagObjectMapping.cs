using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcSystemtagObjectMapping
{
    public string Objectid { get; set; } = null!;

    public string Objecttype { get; set; } = null!;

    public long Systemtagid { get; set; }
}
