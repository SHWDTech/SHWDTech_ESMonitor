using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 系统配置接口
    /// </summary>
    public interface ISystemEsConfig : ISystemEsModel
    {
        /// <summary>
        /// 系统设置名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 系统设置类型
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 系统设置值
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// 父级系统设置项Guid
        /// </summary>
        Guid? ParentSystemConfigGuid { get; set; }

        /// <summary>
        /// 父级系统设置项
        /// </summary>
        EsSystemConfig ParentEsSystemConfig { get; set; }
    }
}
