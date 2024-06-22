using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarsubscription
{
    public long Id { get; set; }

    public string? Uri { get; set; }

    public string? Principaluri { get; set; }

    public string? Displayname { get; set; }

    public string? Refreshrate { get; set; }

    public int Calendarorder { get; set; }

    public string? Calendarcolor { get; set; }

    public short? Striptodos { get; set; }

    public short? Stripalarms { get; set; }

    public short? Stripattachments { get; set; }

    public int? Lastmodified { get; set; }

    public int Synctoken { get; set; }

    public string? Source { get; set; }
}
