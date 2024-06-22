using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcNotificationsPushhash
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public int Token { get; set; }

    public string Deviceidentifier { get; set; } = null!;

    public string Devicepublickey { get; set; } = null!;

    public string Devicepublickeyhash { get; set; } = null!;

    public string Pushtokenhash { get; set; } = null!;

    public string Proxyserver { get; set; } = null!;

    public string Apptype { get; set; } = null!;
}
