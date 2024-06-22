using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcCardsProperty
{
    public long Id { get; set; }

    public long Addressbookid { get; set; }

    public long Cardid { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public int Preferred { get; set; }
}
