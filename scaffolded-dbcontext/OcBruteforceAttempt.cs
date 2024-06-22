using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcBruteforceAttempt
{
    public long Id { get; set; }

    public string Action { get; set; } = null!;

    public int Occurred { get; set; }

    public string Ip { get; set; } = null!;

    public string Subnet { get; set; } = null!;

    public string Metadata { get; set; } = null!;
}
