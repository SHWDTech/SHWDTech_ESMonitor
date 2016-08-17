using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 协议数据
    /// </summary>
    [Serializable]
    public class ProtocolData : BaseDataModel, IProtocolData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Guid { get; set; }

        [Required]
        [Display(Name = "协议所属设备")]
        public virtual Guid DeviceGuid { get; set; }

        [Display(Name = "协议所属设备")]
        [ForeignKey("DeviceGuid")]
        public virtual Device Device { get; set; }

        [Required]
        [Display(Name = "协议内容")]
        public virtual byte[] ProtocolContent { get; set; }

        [Required]
        [Display(Name = "协议长度")]
        public virtual int Length { get; set; }

        [Required]
        [Display(Name = "协议类型")]
        public virtual Guid ProtocolGuid { get; set; }

        [Display(Name = "协议类型")]
        [ForeignKey("ProtocolGuid")]
        public virtual Protocol Protocol { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "协议包组包完成时间")]
        public virtual DateTime ProtocolTime { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "协议数据更新时间")]
        public virtual DateTime UpdateTime { get; set; }
    }
}
