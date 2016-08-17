using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 用户配置模型接口
    /// </summary>
    public interface IUserConfig : ISystemDomainModel
    {
        /// <summary>
        /// 用户配置名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 用户配置类型
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 用户配置值
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// 用户配置所属父级配置项Guid
        /// </summary>
        Guid? ParentUserConfigGuid { get; set; }

        /// <summary>
        /// 用户配置所属父级配置项
        /// </summary>
        UserConfig ParentUserConfig { get; set; }
    }
}
