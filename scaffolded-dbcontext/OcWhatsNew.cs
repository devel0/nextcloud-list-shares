using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcWhatsNew
{
    public int Id { get; set; }

    public string Version { get; set; } = null!;

    public string Etag { get; set; } = null!;

    public int LastCheck { get; set; }

    public string Data { get; set; } = null!;
}
