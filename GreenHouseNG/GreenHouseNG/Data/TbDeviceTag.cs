﻿using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbDeviceTag
{
    public int IdDeviceTag { get; set; }

    public string LableTag { get; set; } = null!;

    public int IdDevice { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual TbDevice IdDeviceNavigation { get; set; } = null!;

    public virtual ICollection<TbDeviceIotag> TbDeviceIotags { get; set; } = new List<TbDeviceIotag>();
}
