using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcSharesLimit
{
    public string Id { get; set; } = null!;

    public long Limit { get; set; }

    public long Downloads { get; set; }
}
