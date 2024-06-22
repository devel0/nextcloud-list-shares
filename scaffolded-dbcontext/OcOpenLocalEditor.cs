using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcOpenLocalEditor
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string PathHash { get; set; } = null!;

    public long ExpirationTime { get; set; }

    public string Token { get; set; } = null!;
}
