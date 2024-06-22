using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCard
{
    public long Id { get; set; }

    public long Addressbookid { get; set; }

    public byte[]? Carddata { get; set; }

    public string? Uri { get; set; }

    public long? Lastmodified { get; set; }

    public string? Etag { get; set; }

    public long Size { get; set; }

    public string? Uid { get; set; }
}
