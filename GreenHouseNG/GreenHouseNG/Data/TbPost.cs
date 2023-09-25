using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbPost
{
    public int IdPost { get; set; }

    public string TittlePost { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<TbAgent> TbAgents { get; set; } = new List<TbAgent>();
}
