using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcDavAbsence
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string FirstDay { get; set; } = null!;

    public string LastDay { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Message { get; set; } = null!;
}
