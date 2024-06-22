using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcProfileConfig
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Config { get; set; } = null!;
}
