using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcOauth2AccessToken
{
    public int Id { get; set; }

    public int TokenId { get; set; }

    public int ClientId { get; set; }

    public string HashedCode { get; set; } = null!;

    public string EncryptedToken { get; set; } = null!;

    public long CodeCreatedAt { get; set; }

    public long TokenCount { get; set; }
}
