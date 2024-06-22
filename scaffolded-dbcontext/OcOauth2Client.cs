using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcOauth2Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RedirectUri { get; set; } = null!;

    public string ClientIdentifier { get; set; } = null!;

    public string Secret { get; set; } = null!;
}
