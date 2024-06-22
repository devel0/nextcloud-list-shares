using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFlowOperationsScope
{
    public long Id { get; set; }

    public int OperationId { get; set; }

    public int Type { get; set; }

    public string? Value { get; set; }
}
