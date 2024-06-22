using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarRoomsMd
{
    public long Id { get; set; }

    public long RoomId { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }
}
