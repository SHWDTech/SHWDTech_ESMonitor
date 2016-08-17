using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 权限
    /// </summary>
    [Serializable]
    public class Permission : BaseSystemDoaminModel, IPermission
    {
        [Required]
        [Display(Name = "权限名称")]
        [MaxLength(50)]
        public virtual string PermissionName { get; set; }

        [Required]
        [Display(Name = "权限显示名称")]
        [MaxLength(50)]
        public virtual string PermissionDisplayName { get; set; }

        [Display(Name = "父级权限ID")]
        public virtual Guid? ParentPermissionGuid { get; set; }

        [Display(Name = "父级权限")]
        [ForeignKey("ParentPermissionId")]
        public virtual Permission ParentPermission { get; set; }

        [Display(Name = "拥有权限的角色")]
        public virtual ICollection<EsRole> Roles { get; set; }

        [Display(Name = "拥有权限的用户")]
        public virtual ICollection<EsUser> Users { get; set; }
    }
}
