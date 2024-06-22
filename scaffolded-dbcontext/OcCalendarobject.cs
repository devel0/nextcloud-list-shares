using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarobject
{
    public long Id { get; set; }

    public byte[]? Calendardata { get; set; }

    public string? Uri { get; set; }

    public long Calendarid { get; set; }

    public int? Lastmodified { get; set; }

    public string? Etag { get; set; }

    public long Size { get; set; }

    public string? Componenttype { get; set; }

    public long? Firstoccurence { get; set; }

    public long? Lastoccurence { get; set; }

    public string? Uid { get; set; }

    public int? Classification { get; set; }

    public int Calendartype { get; set; }

    public int? DeletedAt { get; set; }
}
