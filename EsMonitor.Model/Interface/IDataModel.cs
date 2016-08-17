using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 数据模型基类接口
    /// </summary>
    public interface IDataModel : IModel
    {
        /// <summary>
        /// 数据所属域Guid
        /// </summary>
        Guid DomainGuid { get; set; }

        /// <summary>
        /// 数据所属域
        /// </summary>
        Domain Domain { get; set; }
    }
}
