using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTextSession
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public string? GuestName { get; set; }

    public string? Color { get; set; }

    public string Token { get; set; } = null!;

    public long DocumentId { get; set; }

    public long LastContact { get; set; }

    public string? LastAwarenessMessage { get; set; }
}
