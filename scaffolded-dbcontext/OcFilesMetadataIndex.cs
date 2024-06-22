using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilesMetadataIndex
{
    public long Id { get; set; }

    public long FileId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValueString { get; set; }

    public long? MetaValueInt { get; set; }
}
