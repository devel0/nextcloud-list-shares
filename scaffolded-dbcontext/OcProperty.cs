using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcProperty
{
    public long Id { get; set; }

    public string Userid { get; set; } = null!;

    public string Propertypath { get; set; } = null!;

    public string Propertyname { get; set; } = null!;

    public string Propertyvalue { get; set; } = null!;

    public short? Valuetype { get; set; }
}
