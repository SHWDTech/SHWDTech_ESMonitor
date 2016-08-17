using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 报警类型
    /// </summary>
    public enum AlarmType : byte
    {
        /// <summary>
        /// 总体扬尘值
        /// </summary>
        [Display(Name = "总体扬尘值")]
        Tsp = 0x00,

        /// <summary>
        /// 噪音值
        /// </summary>
        [Display(Name = "噪音值")]
        Noise = 0x01,

        /// <summary>
        /// PM2.5
        /// </summary>
        [Display(Name = "PM2.5")]
        Pm25 = 0x02,

        /// <summary>
        /// PM10
        /// </summary>
        [Display(Name = "PM10")]
        Pm100 = 0x03
    }
}
