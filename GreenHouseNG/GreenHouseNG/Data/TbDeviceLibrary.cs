using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbDeviceLibrary
{
    public int IdLibDevice { get; set; }

    public string EnNameLib { get; set; } = null!;

    public string FaNameLib { get; set; } = null!;

    public int AnalogInput { get; set; }

    public int AnalogOutput { get; set; }

    public int DigitalInput { get; set; }

    public int DigitalOutput { get; set; }

    public string? ImageIcon { get; set; }

    public bool HasGsm { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<TbDevice> TbDevices { get; set; } = new List<TbDevice>();
}
