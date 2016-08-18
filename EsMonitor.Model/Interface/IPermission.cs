using System;
using System.Collections.Generic;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 权限模型接口
    /// </summary>
    public interface IPermission : ISystemEsDomainModel
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        string PermissionName { get; set; }

        /// <summary>
        /// 权限显示名称
        /// </summary>
        string PermissionDisplayName { get; set; }

        /// <summary>
        /// 所属父级权限Guid
        /// </summary>
        Guid? ParentPermissionGuid { get; set; }

        /// <summary>
        /// 所属父级权限
        /// </summary>
        Permission ParentPermission { get; set; }

        /// <summary>
        /// 拥有权限的角色
        /// </summary>
        ICollection<EsRole> Roles { get; set; }

        /// <summary>
        /// 拥有权限的用户
        /// </summary>
        ICollection<EsUser> Users { get; set; }
    }
}
