using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcLoginFlowV2
{
    public long Id { get; set; }

    public long Timestamp { get; set; }

    public short Started { get; set; }

    public string PollToken { get; set; } = null!;

    public string LoginToken { get; set; } = null!;

    public string PublicKey { get; set; } = null!;

    public string PrivateKey { get; set; } = null!;

    public string ClientName { get; set; } = null!;

    public string? LoginName { get; set; }

    public string? Server { get; set; }

    public string? AppPassword { get; set; }
}
