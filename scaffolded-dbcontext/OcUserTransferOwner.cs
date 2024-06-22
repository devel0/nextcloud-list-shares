using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcUserTransferOwner
{
    public long Id { get; set; }

    public string SourceUser { get; set; } = null!;

    public string TargetUser { get; set; } = null!;

    public long FileId { get; set; }

    public string NodeName { get; set; } = null!;
}
