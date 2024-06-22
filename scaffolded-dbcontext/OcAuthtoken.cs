using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcAuthtoken
{
    public long Id { get; set; }

    public string Uid { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string? Password { get; set; }

    public string Name { get; set; } = null!;

    public string Token { get; set; } = null!;

    public short? Type { get; set; }

    public short? Remember { get; set; }

    public int? LastActivity { get; set; }

    public int? LastCheck { get; set; }

    public string? Scope { get; set; }

    public int? Expires { get; set; }

    public string? PrivateKey { get; set; }

    public string? PublicKey { get; set; }

    public short Version { get; set; }

    public bool? PasswordInvalid { get; set; }

    public string? PasswordHash { get; set; }
}
