using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbSchedule
{
    public int IdSchedule { get; set; }

    public int ScheduleType { get; set; }

    public decimal? TimeSchedule { get; set; }

    public bool IsActive { get; set; }

    public int IdFunction { get; set; }

    public virtual TbFunction IdFunctionNavigation { get; set; } = null!;

    public virtual ICollection<TbConstTime> TbConstTimes { get; set; } = new List<TbConstTime>();

    public virtual ICollection<TbInterval> TbIntervals { get; set; } = new List<TbInterval>();
}
