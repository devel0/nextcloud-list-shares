using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFlowOperation
{
    public int Id { get; set; }

    public string Class { get; set; } = null!;

    public string? Name { get; set; }

    public string? Checks { get; set; }

    public string? Operation { get; set; }

    public string Entity { get; set; } = null!;

    public string Events { get; set; } = null!;
}
