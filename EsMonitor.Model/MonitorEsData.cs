﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 监测数据
    /// </summary>
    [Serializable]
    public class MonitorEsData : BaseEsDataModel, IMonitorDataEs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Guid { get; set; }

        [Required]
        [Display(Name = "数据来源协议包")]
        public virtual Guid ProtocolDataGuid { get; set; }

        [Display(Name = "数据来源协议包")]
        [ForeignKey("ProtocolDataGuid")]
        public virtual ProtocolData ProtocolData { get; set; }

        [Required]
        [Display(Name = "数据类型ID")]
        public virtual Guid CommandDataId { get; set; }

        [Display(Name = "数据类型")]
        [ForeignKey("CommandDataId")]
        public virtual CommandData CommandData { get; set; }

        [Display(Name = "数据来源通道号")]
        public virtual short DataChannel { get; set; } = 0;

        [Display(Name = "来源工地ID")]
        public virtual Guid? ProjectId { get; set; }

        [Display(Name = "来源工地")]
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [NotMapped]
        [Display(Name = "数据名称")]
        public virtual string DataName => CommandData.DataName;

        [NotMapped]
        public virtual Device Device => ProtocolData.Device;

        [NotMapped]
        public virtual Guid DeviceId => Device.Guid;

        [Display(Name = "浮点数据值")]
        public virtual double? DoubleValue { get; set; }

        [Display(Name = "布尔数据值")]
        public virtual bool? BooleanValue { get; set; }

        [Display(Name = "整型数据值")]
        public virtual int? IntegerValue { get; set; }

        [Required]
        [Display(Name = "数据上传时间")]
        public virtual DateTime UpdateTime { get; set; }

        [Display(Name = "是否有效数据")]
        public virtual bool DataIsValid { get; set; }
    }
}
