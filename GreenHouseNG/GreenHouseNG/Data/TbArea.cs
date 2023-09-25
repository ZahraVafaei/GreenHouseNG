using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbArea
{
    public int IdArea { get; set; }

    public string NameFa { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public bool IsActive { get; set; }

    public string? ImageIcon { get; set; }

    public string? ImageArea { get; set; }

    public virtual ICollection<TbAlarm> TbAlarms { get; set; } = new List<TbAlarm>();

    public virtual ICollection<TbAreaEnvironment> TbAreaEnvironments { get; set; } = new List<TbAreaEnvironment>();

    public virtual ICollection<TbFormula> TbFormulas { get; set; } = new List<TbFormula>();

    public virtual ICollection<TbFunction> TbFunctions { get; set; } = new List<TbFunction>();

    public virtual ICollection<TbGateway> TbGateways { get; set; } = new List<TbGateway>();

    public virtual ICollection<TbLicence> TbLicences { get; set; } = new List<TbLicence>();

    public virtual ICollection<TbRole> TbRoles { get; set; } = new List<TbRole>();

    public virtual ICollection<TbStateGroup> TbStateGroups { get; set; } = new List<TbStateGroup>();
}
