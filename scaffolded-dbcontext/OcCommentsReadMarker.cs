using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCommentsReadMarker
{
    public string UserId { get; set; } = null!;

    public string ObjectType { get; set; } = null!;

    public string ObjectId { get; set; } = null!;

    public DateTime? MarkerDatetime { get; set; }
}
