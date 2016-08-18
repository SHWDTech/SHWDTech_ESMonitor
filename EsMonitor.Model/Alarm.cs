using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model
{
    /// <summary>
    /// 报警信息
    /// </summary>
    [Serializable]
    public class Alarm : BaseEsDataModel, IAlarm
    {
        [Required]
        [Display(Name = "报警信息来源设备")]
        public virtual Guid AlarmDeviceGuid { get; set; }

        [ForeignKey("AlarmDeviceGuid")]
        [Display(Name = "报警信息来源设备")]
        public virtual Device AlarmDevice { get; set; }

        [Display(Name = "报警信息值")]
        public virtual double AlarmValue { get; set; }

        [Required]
        [Display(Name = "报警类型")]
        public virtual AlarmType AlarmType { get; set; }

        [Required]
        [Display(Name = "报警码")]
        public virtual int AlarmCode { get; set; }

        [Required]
        [Display(Name = "报警信息更新时间")]
        public virtual DateTime UpdateTime { get; set; }
    }
}
