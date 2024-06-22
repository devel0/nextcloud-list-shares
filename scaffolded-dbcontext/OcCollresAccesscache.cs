using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCollresAccesscache
{
    public string UserId { get; set; } = null!;

    public long CollectionId { get; set; }

    public string ResourceType { get; set; } = null!;

    public string ResourceId { get; set; } = null!;

    public bool? Access { get; set; }
}
