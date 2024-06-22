using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcTwofactorBackupcode
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Code { get; set; } = null!;

    public short Used { get; set; }
}
