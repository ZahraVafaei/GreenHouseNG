using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbVaribleType
{
    public int IdVaribleType { get; set; }

    public string IndexType { get; set; } = null!;

    public string EnTitleVaribleType { get; set; } = null!;

    public string FaTitleVaribleType { get; set; } = null!;

    public string? ImageIcon { get; set; }

    public bool IsActive { get; set; }

    public string TableName { get; set; } = null!;

    public string FildName { get; set; } = null!;

    public string FildId { get; set; } = null!;

    public virtual ICollection<TbCondition> TbConditionIdVaribleTypeXNavigations { get; set; } = new List<TbCondition>();

    public virtual ICollection<TbCondition> TbConditionIdVaribleTypeYNavigations { get; set; } = new List<TbCondition>();

    public virtual ICollection<TbThenAction> TbThenActions { get; set; } = new List<TbThenAction>();
}
