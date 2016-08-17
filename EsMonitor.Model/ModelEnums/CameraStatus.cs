using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 摄像头状态
    /// </summary>
    public enum CameraStatus : byte
    {
        /// <summary>
        /// 未关联设备
        /// </summary>
        [Display(Name = "未关联设备")]
        NotRelated = 0x00,

        /// <summary>
        /// 未初始化
        /// </summary>
        [Display(Name = "未初始化")]
        NotInitialized = 0x01,

        /// <summary>
        /// 已经启用
        /// </summary>
        [Display(Name = "已经启用")]
        Enabled = 0x02,

        /// <summary>
        /// 已经停用
        /// </summary>
        [Display(Name = "已经停用")]
        Disabled = 0x03
    }
}
