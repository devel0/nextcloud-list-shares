using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesMountpoint
{
    public int Id { get; set; }

    public string MountId { get; set; } = null!;

    public string SingleId { get; set; } = null!;

    public string? Mountpoint { get; set; }

    public string? MountpointHash { get; set; }
}
