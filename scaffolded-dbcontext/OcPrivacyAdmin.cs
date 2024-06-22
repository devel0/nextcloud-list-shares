using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcPrivacyAdmin
{
    public int Id { get; set; }

    public string Displayname { get; set; } = null!;
}
