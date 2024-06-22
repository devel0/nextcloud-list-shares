using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcNotificationsSetting
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public int BatchTime { get; set; }

    public long LastSendId { get; set; }

    public int NextSendTime { get; set; }
}
