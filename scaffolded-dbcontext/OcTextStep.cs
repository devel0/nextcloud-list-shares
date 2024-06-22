using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTextStep
{
    public long Id { get; set; }

    public long DocumentId { get; set; }

    public long SessionId { get; set; }

    public string Data { get; set; } = null!;

    public long? Version { get; set; }
}
