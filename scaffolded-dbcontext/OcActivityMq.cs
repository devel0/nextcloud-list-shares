using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcActivityMq
{
    public long MailId { get; set; }

    public int AmqTimestamp { get; set; }

    public int AmqLatestSend { get; set; }

    public string AmqType { get; set; } = null!;

    public string AmqAffecteduser { get; set; } = null!;

    public string AmqAppid { get; set; } = null!;

    public string AmqSubject { get; set; } = null!;

    public string? AmqSubjectparams { get; set; }

    public string? ObjectType { get; set; }

    public long ObjectId { get; set; }
}
