using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcRecentContact
{
    public int Id { get; set; }

    public string ActorUid { get; set; } = null!;

    public string? Uid { get; set; }

    public string? Email { get; set; }

    public string? FederatedCloudId { get; set; }

    public byte[] Card { get; set; } = null!;

    public int LastContact { get; set; }
}
