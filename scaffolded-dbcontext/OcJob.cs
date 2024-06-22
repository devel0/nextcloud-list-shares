using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcJob
{
    public long Id { get; set; }

    public string Class { get; set; } = null!;

    public string Argument { get; set; } = null!;

    public int? LastRun { get; set; }

    public int? LastChecked { get; set; }

    public int? ReservedAt { get; set; }

    public int? ExecutionDuration { get; set; }

    public string? ArgumentHash { get; set; }

    public short TimeSensitive { get; set; }
}
