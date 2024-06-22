using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesMembership
{
    public string CircleId { get; set; } = null!;

    public string SingleId { get; set; } = null!;

    public int Level { get; set; }

    public string InheritanceFirst { get; set; } = null!;

    public string InheritanceLast { get; set; } = null!;

    public int InheritanceDepth { get; set; }

    public string InheritancePath { get; set; } = null!;
}
