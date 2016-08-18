using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model
{
    /// <summary>
    /// 设备
    /// </summary>
    [Serializable]
    public class Device : BaseEsSystemDoaminModel, IDevice
    {
        [Required]
        [Display(Name = "设备类型")]
        public virtual Guid DeviceTypeGuid { get; set; }

        [Display(Name = "设备类型")]
        [ForeignKey("DeviceTypeGuid")]
        public virtual DeviceType DeviceType { get; set; }

        [Display(Name = "设备对应的原设备")]
        public virtual Guid? OriginalDeviceGuid { get; set; }

        [Display(Name = "设备对应的原设备")]
        [ForeignKey("OriginalDeviceGuid")]
        public virtual Device OriginalDevice { get; set; }

        [Required]
        [Display(Name = "设备名称")]
        [MaxLength(25)]
        public virtual string DeviceCode { get; set; }

        [Display(Name = "监测点编号")]
        public virtual int? StatCode { get; set; }

        [MaxLength(25)]
        [Display(Name = "设备访问密码")]
        public virtual string DevicePassword { get; set; }

        [Display(Name = "设备唯一标识符")]
        public virtual Guid? DeviceModuleGuid { get; set; }

        [Display(Name = "设备NODE编码")]
        [MaxLength(16)]
        public virtual string DeviceNodeId { get; set; }

        [Required]
        [Display(Name = "设备关联固件集")]
        public virtual Guid FirmwareSetGuid { get; set; }

        [Display(Name = "设备关联固件集")]
        [ForeignKey("FirmwareSetGuid")]
        public virtual FirmwareSet FirmwareSet { get; set; }

        [Display(Name = "设备所属项目")]
        public virtual Guid? ProjectGuid { get; set; }

        [Display(Name = "设备所属项目")]
        [ForeignKey("ProjectGuid")]
        public virtual Project Project { get; set; }

        [Display(Name = "设备启用时间")]
        public virtual DateTime? StartTime { get; set; }

        [Display(Name = "设备预定启用时间")]
        public virtual DateTime? PreEndTime { get; set; }

        [Display(Name = "设备结束时间")]
        public virtual DateTime? EndTime { get; set; }

        [Display(Name = "设备状态")]
        public virtual DeviceStatus Status { get; set; }

        [Display(Name = "设备关联摄像头ID")]
        public Guid? CameraGuid { get; set; }

        [Display(Name = "设备关联摄像头")]
        [ForeignKey("CameraGuid")]
        public virtual Camera Camera { get; set; }
    }
}
