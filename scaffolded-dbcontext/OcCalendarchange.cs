using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarchange
{
    public long Id { get; set; }

    public string? Uri { get; set; }

    public int Synctoken { get; set; }

    public long Calendarid { get; set; }

    public short Operation { get; set; }

    public int Calendartype { get; set; }

    public int CreatedAt { get; set; }
}
