using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilecacheExtended
{
    public long Fileid { get; set; }

    public string? MetadataEtag { get; set; }

    public long CreationTime { get; set; }

    public long UploadTime { get; set; }
}
