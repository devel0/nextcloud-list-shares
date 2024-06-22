using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcWebauthn
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string PublicKeyCredentialId { get; set; } = null!;

    public string Data { get; set; } = null!;
}
