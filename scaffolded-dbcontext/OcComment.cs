using System;
using System.Collections.Generic;

namespace nextcloud_list_shares.scaffolded_dbcontext;

public partial class OcComment
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public long TopmostParentId { get; set; }

    public int ChildrenCount { get; set; }

    public string ActorType { get; set; } = null!;

    public string ActorId { get; set; } = null!;

    public string? Message { get; set; }

    public string? Verb { get; set; }

    public DateTime? CreationTimestamp { get; set; }

    public DateTime? LatestChildTimestamp { get; set; }

    public string ObjectType { get; set; } = null!;

    public string ObjectId { get; set; } = null!;

    public string? ReferenceId { get; set; }

    public string? Reactions { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? MetaData { get; set; }
}
