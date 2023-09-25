using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbIntervalGroup
{
    public int IdIntervalGroup { get; set; }

    public string FaIntervalGroupName { get; set; } = null!;

    public string EnIntervalGroupName { get; set; } = null!;

    public virtual ICollection<TbIntervalSub> TbIntervalSubs { get; set; } = new List<TbIntervalSub>();
}
