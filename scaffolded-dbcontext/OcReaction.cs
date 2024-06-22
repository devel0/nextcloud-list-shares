using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcReaction
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public long MessageId { get; set; }

    public string ActorType { get; set; } = null!;

    public string ActorId { get; set; } = null!;

    public string Reaction { get; set; } = null!;
}
