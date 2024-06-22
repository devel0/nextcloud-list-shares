using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcActivity
{
    public long ActivityId { get; set; }

    public int Timestamp { get; set; }

    public int Priority { get; set; }

    public string? Type { get; set; }

    public string? User { get; set; }

    public string Affecteduser { get; set; } = null!;

    public string App { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Subjectparams { get; set; } = null!;

    public string? Message { get; set; }

    public string? Messageparams { get; set; }

    public string? File { get; set; }

    public string? Link { get; set; }

    public string? ObjectType { get; set; }

    public long ObjectId { get; set; }
}
