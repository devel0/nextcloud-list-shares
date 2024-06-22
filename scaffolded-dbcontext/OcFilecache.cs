using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilecache
{
    public long Fileid { get; set; }

    public long Storage { get; set; }

    public string? Path { get; set; }

    public string PathHash { get; set; } = null!;

    public long Parent { get; set; }

    public string? Name { get; set; }

    public long Mimetype { get; set; }

    public long Mimepart { get; set; }

    public long Size { get; set; }

    public long Mtime { get; set; }

    public long StorageMtime { get; set; }

    public int Encrypted { get; set; }

    public long UnencryptedSize { get; set; }

    public string? Etag { get; set; }

    public int? Permissions { get; set; }

    public string? Checksum { get; set; }
}
