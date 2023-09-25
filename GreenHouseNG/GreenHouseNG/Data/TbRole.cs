using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbRole
{
    public int IdRole { get; set; }

    public int IdArea { get; set; }

    public string EnTittle { get; set; } = null!;

    public string FaTittle { get; set; } = null!;

    public bool IsActive { get; set; }

    public string RoleDescription { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public string FileStyle { get; set; } = null!;

    public virtual TbArea IdAreaNavigation { get; set; } = null!;

    public virtual ICollection<TbAccessRole> TbAccessRoles { get; set; } = new List<TbAccessRole>();

    public virtual ICollection<TbAlarmRole> TbAlarmRoles { get; set; } = new List<TbAlarmRole>();

    public virtual ICollection<TbUser> TbUsers { get; set; } = new List<TbUser>();
}
