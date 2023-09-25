using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbPremissionRole
{
    public int IdPremissionRole { get; set; }

    public string Tittle { get; set; } = null!;

    public string Root { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<TbAccessRole> TbAccessRoles { get; set; } = new List<TbAccessRole>();
}
