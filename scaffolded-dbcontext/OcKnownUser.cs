using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcKnownUser
{
    public long Id { get; set; }

    public string KnownTo { get; set; } = null!;

    public string KnownUser { get; set; } = null!;
}
