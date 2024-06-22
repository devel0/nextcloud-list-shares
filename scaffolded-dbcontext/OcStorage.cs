using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcStorage
{
    public long NumericId { get; set; }

    public string? Id { get; set; }

    public int Available { get; set; }

    public int? LastChecked { get; set; }
}
