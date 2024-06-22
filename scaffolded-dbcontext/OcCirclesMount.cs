using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesMount
{
    public int Id { get; set; }

    public string MountId { get; set; } = null!;

    public string CircleId { get; set; } = null!;

    public string SingleId { get; set; } = null!;

    public string? Token { get; set; }

    public int? Parent { get; set; }

    public string? Mountpoint { get; set; }

    public string? MountpointHash { get; set; }
}
