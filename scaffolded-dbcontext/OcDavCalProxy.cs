using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcDavCalProxy
{
    public long Id { get; set; }

    public string OwnerId { get; set; } = null!;

    public string ProxyId { get; set; } = null!;

    public int? Permissions { get; set; }
}
