using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcAuthorizedGroup
{
    public int Id { get; set; }

    public string GroupId { get; set; } = null!;

    public string Class { get; set; } = null!;
}
