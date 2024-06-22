using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcVcategory
{
    public long Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Category { get; set; } = null!;
}
