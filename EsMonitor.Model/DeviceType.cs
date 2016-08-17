using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 设备类型类型
    /// </summary>
    [Serializable]
    public class DeviceType : BaseSystemModel, IDeviceType
    {
        [Required]
        [Display(Name = "设备类型应用领域")]
        public Guid FieldGuid { get; set; }

        [Display(Name = "设备类型应用领域")]
        [ForeignKey("FieldId")]
        public virtual SystemDictionary Field { get; set; }

        [Required]
        [Display(Name = "设备类型应用子领域")]
        public Guid SubFieldGuid { get; set; }

        [ForeignKey("SubFieldId")]
        [Display(Name = "设备类型应用子领域")]
        public virtual SystemDictionary SubField { get; set; }

        [Display(Name = "设备类型自定义字段")]
        public virtual string CustomerInfo { get; set; }

        [Required]
        [Display(Name = "设备类型版本")]
        public virtual string Version { get; set; }

        [Required]
        [Display(Name = "设备类型发布时间")]
        public virtual DateTime ReleaseDateTime { get; set; }

        [Required]
        [Display(Name = "设备类型类型编码")]
        public virtual string DeviceTypeCode { get; set; }
    }
}
