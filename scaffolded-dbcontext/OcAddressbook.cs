using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcAddressbook
{
    public long Id { get; set; }

    public string? Principaluri { get; set; }

    public string? Displayname { get; set; }

    public string? Uri { get; set; }

    public string? Description { get; set; }

    public int Synctoken { get; set; }
}
