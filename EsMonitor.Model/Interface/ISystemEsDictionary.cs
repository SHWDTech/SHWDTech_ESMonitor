using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 系统自定义字典接口
    /// </summary>
    public interface ISystemEsDictionary : ISystemEsModel
    {
        /// <summary>
        /// 字典名称
        /// </summary>
        string ItemName { get; set; }

        /// <summary>
        /// 字典项关键字
        /// </summary>
        string ItemKey { get; set; }

        /// <summary>
        /// 字典项值
        /// </summary>
        string ItemValue { get; set; }

        /// <summary>
        /// 字典项层级
        /// </summary>
        byte ItemLevel { get; set; }

        /// <summary>
        /// 父级字典项Guid
        /// </summary>
        Guid? ParentDictionaryGuid { get; set; }

        /// <summary>
        /// 父级字典项
        /// </summary>
        EsSystemDictionary ParentDictionary { get; }
    }
}
