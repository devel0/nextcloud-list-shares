using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFileLock
{
    public long Id { get; set; }

    public int Lock { get; set; }

    public string Key { get; set; } = null!;

    public int Ttl { get; set; }
}
