using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcShare
{
    public long Id { get; set; }

    public short ShareType { get; set; }

    public string? ShareWith { get; set; }

    public string? Password { get; set; }

    public string UidOwner { get; set; } = null!;

    public string? UidInitiator { get; set; }

    public long? Parent { get; set; }

    public string ItemType { get; set; } = null!;

    public string? ItemSource { get; set; }

    public string? ItemTarget { get; set; }

    public long? FileSource { get; set; }

    public string? FileTarget { get; set; }

    public short Permissions { get; set; }

    public long Stime { get; set; }

    public short Accepted { get; set; }

    public DateTime? Expiration { get; set; }

    public string? Token { get; set; }

    public short MailSend { get; set; }

    public string? ShareName { get; set; }

    public bool? PasswordByTalk { get; set; }

    public string? Note { get; set; }

    public short? HideDownload { get; set; }

    public string? Label { get; set; }

    public string? Attributes { get; set; }

    public DateTime? PasswordExpirationTime { get; set; }
}
