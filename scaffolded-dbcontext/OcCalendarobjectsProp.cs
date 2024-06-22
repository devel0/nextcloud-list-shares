using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarobjectsProp
{
    public long Id { get; set; }

    public long Calendarid { get; set; }

    public long Objectid { get; set; }

    public string? Name { get; set; }

    public string? Parameter { get; set; }

    public string? Value { get; set; }

    public int Calendartype { get; set; }
}
