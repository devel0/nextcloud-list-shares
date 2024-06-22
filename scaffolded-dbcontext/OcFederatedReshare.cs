using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFederatedReshare
{
    public long ShareId { get; set; }

    public string? RemoteId { get; set; }
}
