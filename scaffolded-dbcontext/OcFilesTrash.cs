using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcFilesTrash
{
    public long AutoId { get; set; }

    public string Id { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Timestamp { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Type { get; set; }

    public string? Mime { get; set; }
}
