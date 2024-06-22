using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcText2imageTask
{
    public long Id { get; set; }

    public string Input { get; set; } = null!;

    public int? Status { get; set; }

    public int NumberOfImages { get; set; }

    public string? UserId { get; set; }

    public string AppId { get; set; } = null!;

    public string? Identifier { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? CompletionExpectedAt { get; set; }
}
