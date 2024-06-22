using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendar
{
    public long Id { get; set; }

    public string? Principaluri { get; set; }

    public string? Displayname { get; set; }

    public string? Uri { get; set; }

    public int Synctoken { get; set; }

    public string? Description { get; set; }

    public int Calendarorder { get; set; }

    public string? Calendarcolor { get; set; }

    public string? Timezone { get; set; }

    public string? Components { get; set; }

    public short Transparent { get; set; }

    public int? DeletedAt { get; set; }
}
