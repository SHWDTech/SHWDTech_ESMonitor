using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 系统模型接口
    /// </summary>
    public interface ISystemModel : IModel
    {
        /// <summary>
        /// 字段创建时间
        /// </summary>
        DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 字段创建人Guid
        /// </summary>
        Guid CreateUserGuid { get; set; }

        /// <summary>
        /// 字段最后修改时间
        /// </summary>
        DateTime? LastUpdateDateTime { get; set; }

        /// <summary>
        /// 字段最后修改人Guid
        /// </summary>
        Guid? LastUpdateUserGuid { get; set; }
    }
}
