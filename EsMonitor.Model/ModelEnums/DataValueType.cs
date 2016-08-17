using System.ComponentModel.DataAnnotations;

namespace EsMonitor.Model.ModelEnums
{
    /// <summary>
    /// 数据值类型
    /// </summary>
    public enum DataValueType : byte
    {
        /// <summary>
        /// 浮点数
        /// </summary>
        [Display(Name = "浮点数")]
        Double = 0x00,

        /// <summary>
        /// 布尔值
        /// </summary>
        [Display(Name = "布尔值")]
        Boolean = 0x01,

        /// <summary>
        /// 整型数
        /// </summary>
        [Display(Name = "整型数")]
        Integer = 0x02
    }
}
