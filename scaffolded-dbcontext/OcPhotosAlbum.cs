using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcPhotosAlbum
{
    public long AlbumId { get; set; }

    public string Name { get; set; } = null!;

    public string User { get; set; } = null!;

    public long Created { get; set; }

    public string Location { get; set; } = null!;

    public long LastAddedPhoto { get; set; }
}
