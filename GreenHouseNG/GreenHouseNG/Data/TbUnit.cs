using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbUnit
{
    public int IdUnit { get; set; }

    public string FaName { get; set; } = null!;

    public string EnName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<TbLibraryDeviceInputOutput> TbLibraryDeviceInputOutputs { get; set; } = new List<TbLibraryDeviceInputOutput>();
}
