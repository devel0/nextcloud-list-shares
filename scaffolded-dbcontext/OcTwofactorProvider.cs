using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTwofactorProvider
{
    public string ProviderId { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public short Enabled { get; set; }
}
