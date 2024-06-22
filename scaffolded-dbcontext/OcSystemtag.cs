using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcSystemtag
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public short Visibility { get; set; }

    public short Editable { get; set; }
}
