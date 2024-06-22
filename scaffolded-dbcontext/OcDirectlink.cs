using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcDirectlink
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public long FileId { get; set; }

    public string? Token { get; set; }

    public long Expiration { get; set; }
}
