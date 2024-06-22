using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcUser
{
    public string Uid { get; set; } = null!;

    public string? Displayname { get; set; }

    public string Password { get; set; } = null!;

    public string? UidLower { get; set; }
}
