using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarResource
{
    public long Id { get; set; }

    public string? BackendId { get; set; }

    public string? ResourceId { get; set; }

    public string? Email { get; set; }

    public string? Displayname { get; set; }

    public string? GroupRestrictions { get; set; }
}
