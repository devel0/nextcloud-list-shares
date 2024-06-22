using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesEvent
{
    public string Token { get; set; } = null!;

    public string Instance { get; set; } = null!;

    public string? Event { get; set; }

    public string? Result { get; set; }

    public int Interface { get; set; }

    public int? Severity { get; set; }

    public int? Retry { get; set; }

    public int? Status { get; set; }

    public DateTime? Updated { get; set; }

    public long? Creation { get; set; }
}
