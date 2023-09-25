using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbUser
{
    public int IdUser { get; set; }

    public string Uname { get; set; } = null!;

    public string Upass { get; set; } = null!;

    public int IdRole { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string Tel { get; set; } = null!;

    public bool IsEnable { get; set; }

    public DateTime RegisterAt { get; set; }

    public DateTime? LastLogin { get; set; }

   public virtual TbRole IdRoleNavigation { get; set; } = null!;
   // public virtual ICollection<TbRole> TbRoles { get; set; } = new List<TbRole>();


    public virtual ICollection<TbDashboard> TbDashboards { get; set; } = new List<TbDashboard>();

    public virtual ICollection<TbFunction> TbFunctions { get; set; } = new List<TbFunction>();

    public virtual ICollection<TbLogModifyFunction> TbLogModifyFunctions { get; set; } = new List<TbLogModifyFunction>();

    public virtual ICollection<TbLogUser> TbLogUsers { get; set; } = new List<TbLogUser>();
}
