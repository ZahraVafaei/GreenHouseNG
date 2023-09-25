using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbFunction
{
    public int IdFunction { get; set; }

    public int IdArea { get; set; }

    public string EnFunctionName { get; set; } = null!;

    public string FaFunctionName { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public int IdUserCreator { get; set; }

    public bool IsActive { get; set; }

    public bool IsRunning { get; set; }

    public bool IsFault { get; set; }

    public string GroupFunc { get; set; } = null!;

    public int PriorityOn { get; set; }

    public virtual TbArea IdAreaNavigation { get; set; } = null!;

    public virtual TbUser IdUserCreatorNavigation { get; set; } = null!;

    public virtual ICollection<TbCondition> TbConditions { get; set; } = new List<TbCondition>();

    public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdCallerFunctionNavigations { get; set; } = new List<TbLogCallFunction>();

    public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdCancellerFunctionNavigations { get; set; } = new List<TbLogCallFunction>();

    public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdFunctionNavigations { get; set; } = new List<TbLogCallFunction>();

    public virtual ICollection<TbLogModifyFunction> TbLogModifyFunctions { get; set; } = new List<TbLogModifyFunction>();

    public virtual ICollection<TbSchedule> TbSchedules { get; set; } = new List<TbSchedule>();

    public virtual ICollection<TbThenAction> TbThenActions { get; set; } = new List<TbThenAction>();
}
