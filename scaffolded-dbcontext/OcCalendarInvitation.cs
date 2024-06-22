using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarInvitation
{
    public long Id { get; set; }

    public string Uid { get; set; } = null!;

    public string? Recurrenceid { get; set; }

    public string Attendee { get; set; } = null!;

    public string Organizer { get; set; } = null!;

    public long? Sequence { get; set; }

    public string Token { get; set; } = null!;

    public long Expiration { get; set; }
}
