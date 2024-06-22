using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcMimetype
{
    public long Id { get; set; }

    public string Mimetype { get; set; } = null!;
}
