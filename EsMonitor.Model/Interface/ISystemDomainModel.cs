using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 带有域信息得系统模型类接口
    /// </summary>
    public interface ISystemDomainModel : ISystemModel
    {
        /// <summary>
        /// 所属域Guid
        /// </summary>
        Guid DomainGuid { get; set; }

        /// <summary>
        /// 所属域
        /// </summary>
        Domain Domain { get; set; }
    }
}
