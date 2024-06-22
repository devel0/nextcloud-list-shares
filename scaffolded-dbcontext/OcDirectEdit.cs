using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcDirectEdit
{
    public long Id { get; set; }

    public string EditorId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long FileId { get; set; }

    public string? UserId { get; set; }

    public long? ShareId { get; set; }

    public long Timestamp { get; set; }

    public bool? Accessed { get; set; }

    public string? FilePath { get; set; }
}
