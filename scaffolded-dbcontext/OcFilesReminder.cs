using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilesReminder
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long FileId { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? Notified { get; set; }
}
