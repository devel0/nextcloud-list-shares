using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcMount
{
    public long Id { get; set; }

    public long StorageId { get; set; }

    public long RootId { get; set; }

    public string UserId { get; set; } = null!;

    public string MountPoint { get; set; } = null!;

    public long? MountId { get; set; }

    public string? MountProviderClass { get; set; }
}
