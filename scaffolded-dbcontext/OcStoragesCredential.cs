using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcStoragesCredential
{
    public long Id { get; set; }

    public string? User { get; set; }

    public string Identifier { get; set; } = null!;

    public string? Credentials { get; set; }
}
