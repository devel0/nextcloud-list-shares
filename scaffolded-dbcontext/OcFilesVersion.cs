using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilesVersion
{
    public long Id { get; set; }

    public long FileId { get; set; }

    public long Timestamp { get; set; }

    public long Size { get; set; }

    public long Mimetype { get; set; }

    public string Metadata { get; set; } = null!;
}
