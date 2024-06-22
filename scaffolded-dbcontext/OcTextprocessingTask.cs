using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTextprocessingTask
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public string Input { get; set; } = null!;

    public string? Output { get; set; }

    public int? Status { get; set; }

    public string? UserId { get; set; }

    public string AppId { get; set; } = null!;

    public string Identifier { get; set; } = null!;

    public int? LastUpdated { get; set; }

    public DateTime? CompletionExpectedAt { get; set; }
}
