using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesToken
{
    public int Id { get; set; }

    public int? ShareId { get; set; }

    public string? CircleId { get; set; }

    public string? SingleId { get; set; }

    public string? MemberId { get; set; }

    public string? Token { get; set; }

    public string? Password { get; set; }

    public int? Accepted { get; set; }
}
