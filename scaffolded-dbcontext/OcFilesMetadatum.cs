using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilesMetadatum
{
    public long Id { get; set; }

    public long FileId { get; set; }

    public string Json { get; set; } = null!;

    public string SyncToken { get; set; } = null!;

    public DateTime LastUpdate { get; set; }
}
