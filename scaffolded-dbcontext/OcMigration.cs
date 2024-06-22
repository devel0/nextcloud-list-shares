using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcMigration
{
    public string App { get; set; } = null!;

    public string Version { get; set; } = null!;
}
