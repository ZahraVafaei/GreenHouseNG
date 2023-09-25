using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbAgent
{
    public int IdAgent { get; set; }

    public string Aname { get; set; } = null!;

    public string Afamily { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string City { get; set; } = null!;

    public int IdPost { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual TbPost IdPostNavigation { get; set; } = null!;

    public virtual ICollection<TbMission> TbMissions { get; set; } = new List<TbMission>();
}
