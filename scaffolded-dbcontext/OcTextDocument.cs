using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTextDocument
{
    public long Id { get; set; }

    public long? CurrentVersion { get; set; }

    public long? LastSavedVersion { get; set; }

    public long LastSavedVersionTime { get; set; }

    public string? LastSavedVersionEtag { get; set; }

    public string? BaseVersionEtag { get; set; }
}
