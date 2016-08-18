using System;
using System.Collections.Generic;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 用户角色接口
    /// </summary>
    public interface IEsRole : ISystemEsDomainModel
    {
        /// <summary>
        /// 角色所属父角色Guid
        /// </summary>
        Guid? ParentRoleGuid { get; set; }

        /// <summary>
        /// 角色所属父角色
        /// </summary>
        EsRole ParentRole { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        string RoleName { get; set; }

        /// <summary>
        /// 属于该用户的角色
        /// </summary>
        ICollection<EsUser> Users { get; set; }

        /// <summary>
        /// 角色状态
        /// </summary>
        RoleStatus Status { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        string Comments { get; set; }

        /// <summary>
        /// 角色拥有的权限
        /// </summary>
        ICollection<Permission> Permissions { get; set; }
    }
}
