using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 域状态
    /// </summary>
    public enum DomainStatus : byte
    {
        /// <summary>
        /// 启用状态
        /// </summary>
        [Display(Name = "启用")]
        Enabled = 0x00,

        /// <summary>
        /// 非启用状态
        /// </summary>
        [Display(Name = "未启用")]
        Disabled = 0x01
    }
}
