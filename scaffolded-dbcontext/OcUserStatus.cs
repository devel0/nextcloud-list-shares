using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcUserStatus
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int StatusTimestamp { get; set; }

    public bool? IsUserDefined { get; set; }

    public string? MessageId { get; set; }

    public string? CustomIcon { get; set; }

    public string? CustomMessage { get; set; }

    public int? ClearAt { get; set; }

    public bool? IsBackup { get; set; }

    public int StatusMessageTimestamp { get; set; }
}
