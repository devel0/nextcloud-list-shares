using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcPhotosAlbumsFile
{
    public long AlbumFileId { get; set; }

    public long AlbumId { get; set; }

    public long FileId { get; set; }

    public long Added { get; set; }

    public string? Owner { get; set; }
}
