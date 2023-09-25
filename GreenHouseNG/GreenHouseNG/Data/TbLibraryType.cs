﻿using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbLibraryType
{
    public int IdLibType { get; set; }

    public string EnTittleLibType { get; set; } = null!;

    public string FaTittleLibType { get; set; } = null!;

    public string ImageIcon { get; set; } = null!;

    public bool IsActive { get; set; }

    public int PeriodicCheckSecond { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public bool IsSensor { get; set; }

    public virtual ICollection<TbLibraryDeviceInputOutput> TbLibraryDeviceInputOutputs { get; set; } = new List<TbLibraryDeviceInputOutput>();
}
