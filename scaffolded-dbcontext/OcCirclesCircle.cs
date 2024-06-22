using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCirclesCircle
{
    public int Id { get; set; }

    public string UniqueId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? SanitizedName { get; set; }

    public string? Instance { get; set; }

    public int? Config { get; set; }

    public int? Source { get; set; }

    public string? Settings { get; set; }

    public string? Description { get; set; }

    public DateTime? Creation { get; set; }

    public int? ContactAddressbook { get; set; }

    public string? ContactGroupname { get; set; }
}
