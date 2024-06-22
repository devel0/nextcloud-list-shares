using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesShareLock
{
    public int Id { get; set; }

    public string ItemId { get; set; } = null!;

    public string CircleId { get; set; } = null!;

    public string Instance { get; set; } = null!;
}
