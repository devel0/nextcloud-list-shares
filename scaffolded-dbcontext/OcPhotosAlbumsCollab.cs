using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcPhotosAlbumsCollab
{
    public long Id { get; set; }

    public long AlbumId { get; set; }

    public string CollaboratorId { get; set; } = null!;

    public int CollaboratorType { get; set; }
}
