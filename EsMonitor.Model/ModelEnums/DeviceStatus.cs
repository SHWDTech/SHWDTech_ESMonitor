using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 设备状态
    /// </summary>
    public enum DeviceStatus : byte
    {
        /// <summary>
        /// 已经启用
        /// </summary>
        [Display(Name = "使用中")]
        Enabled = 0x00,

        /// <summary>
        /// 未启用
        /// </summary>
        [Display(Name = "停用中")]
        Disabled = 0x01,

        /// <summary>
        /// 维护中
        /// </summary>
        [Display(Name = "维护中")]
        Maintenance = 0x02
    }
}
