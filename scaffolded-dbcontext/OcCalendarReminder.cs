using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCalendarReminder
{
    public long Id { get; set; }

    public long CalendarId { get; set; }

    public long ObjectId { get; set; }

    public short? IsRecurring { get; set; }

    public string Uid { get; set; } = null!;

    public long? RecurrenceId { get; set; }

    public short IsRecurrenceException { get; set; }

    public string EventHash { get; set; } = null!;

    public string AlarmHash { get; set; } = null!;

    public string Type { get; set; } = null!;

    public short IsRelative { get; set; }

    public long NotificationDate { get; set; }

    public short IsRepeatBased { get; set; }
}
