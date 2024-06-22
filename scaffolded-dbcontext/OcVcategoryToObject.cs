using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcVcategoryToObject
{
    public long Objid { get; set; }

    public long Categoryid { get; set; }

    public string Type { get; set; } = null!;
}
