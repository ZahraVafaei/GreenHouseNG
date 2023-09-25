using System;
using System.Collections.Generic;

namespace GreenHouseNG.Data;

public partial class TbCamera
{
    public int IdCamera { get; set; }

    public int IdDevice { get; set; }

    public string EnCameraName { get; set; } = null!;

    public string FaCameraName { get; set; } = null!;

    public string CameraIp { get; set; } = null!;

    public string UserCamera { get; set; } = null!;

    public string PassCamera { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual TbDevice IdDeviceNavigation { get; set; } = null!;

    public virtual ICollection<TbCameraImageStorage> TbCameraImageStorages { get; set; } = new List<TbCameraImageStorage>();

    public virtual ICollection<TbCameraMotionDetection> TbCameraMotionDetections { get; set; } = new List<TbCameraMotionDetection>();
}
