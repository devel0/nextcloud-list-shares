using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcNotification
{
    public int NotificationId { get; set; }

    public string App { get; set; } = null!;

    public string User { get; set; } = null!;

    public int Timestamp { get; set; }

    public string ObjectType { get; set; } = null!;

    public string ObjectId { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? SubjectParameters { get; set; }

    public string? Message { get; set; }

    public string? MessageParameters { get; set; }

    public string? Link { get; set; }

    public string? Icon { get; set; }

    public string? Actions { get; set; }
}
