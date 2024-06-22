using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCollresResource
{
    public long CollectionId { get; set; }

    public string ResourceType { get; set; } = null!;

    public string ResourceId { get; set; } = null!;
}
