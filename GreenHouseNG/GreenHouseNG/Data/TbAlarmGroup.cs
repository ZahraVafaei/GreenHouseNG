using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbAlarmGroup
{
    public int AlarmGroupId { get; set; }

    public string EnName { get; set; } = null!;

    public string FaName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<TbAlarm> TbAlarms { get; set; } = new List<TbAlarm>();
}
