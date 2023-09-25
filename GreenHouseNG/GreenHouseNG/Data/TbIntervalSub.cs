﻿using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbIntervalSub
{
    public int IdIntervalSub { get; set; }

    public short IndexSub { get; set; }

    public string EnTitleSub { get; set; } = null!;

    public string FaTitleSub { get; set; } = null!;

    public int IdIntervalGroup { get; set; }

    public virtual TbIntervalGroup IdIntervalGroupNavigation { get; set; } = null!;

    public virtual ICollection<TbInterval> TbIntervals { get; set; } = new List<TbInterval>();
}
