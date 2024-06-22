using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcShareExternal
{
    public long Id { get; set; }

    public long? Parent { get; set; }

    public int? ShareType { get; set; }

    public string Remote { get; set; } = null!;

    public string? RemoteId { get; set; }

    public string ShareToken { get; set; } = null!;

    public string? Password { get; set; }

    public string Name { get; set; } = null!;

    public string Owner { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Mountpoint { get; set; } = null!;

    public string MountpointHash { get; set; } = null!;

    public int Accepted { get; set; }
}
