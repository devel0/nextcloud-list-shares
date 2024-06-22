using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFlowCheck
{
    public int Id { get; set; }

    public string Class { get; set; } = null!;

    public string Operator { get; set; } = null!;

    public string? Value { get; set; }

    public string Hash { get; set; } = null!;
}
