using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesMember
{
    public int Id { get; set; }

    public string? SingleId { get; set; }

    public string CircleId { get; set; } = null!;

    public string? MemberId { get; set; }

    public string UserId { get; set; } = null!;

    public short UserType { get; set; }

    public string? Instance { get; set; }

    public string? InvitedBy { get; set; }

    public short Level { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CachedName { get; set; }

    public DateTime? CachedUpdate { get; set; }

    public string? ContactId { get; set; }

    public string? ContactMeta { get; set; }

    public DateTime? Joined { get; set; }
}
