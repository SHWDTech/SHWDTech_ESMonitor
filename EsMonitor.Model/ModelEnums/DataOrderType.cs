using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 协议数据段组合方式
    /// </summary>
    public enum DataOrderType : byte
    {
        /// <summary>
        /// 固定顺序
        /// </summary>
        [Display(Name = "固定顺序")]
        Order = 0x00,

        /// <summary>
        /// 自由组合
        /// </summary>
        [Display(Name = "自由组合")]
        Random = 0x01
    }
}
