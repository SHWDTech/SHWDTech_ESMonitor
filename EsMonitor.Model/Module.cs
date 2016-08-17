using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 模块模型对象
    /// </summary>
    [Serializable]
    public class Module : BaseSystemDoaminModel, IModule
    {
        [Display(Name = "所属父模块")]
        public virtual Guid? ParentModuleGuid { get; set; }

        [Display(Name = "所属父模块")]
        [ForeignKey("ParentModuleGuid")]
        public virtual Module ParentModule { get; set; }

        [Required]
        [Display(Name = "是否菜单项")]
        public bool IsMenu { get; set; }

        [Required]
        [Display(Name = "模块层级")]
        public virtual int ModuleLevel { get; set; }

        [Display(Name = "模块索引值")]
        public virtual int ModuleIndex { get; set; }

        [Display(Name = "菜单项图标字符串")]
        public virtual string IconString { get; set; }

        [Required]
        [Display(Name = "模块名称")]
        [MaxLength(25)]
        public virtual string ModuleName { get; set; }

        [Display(Name = "模块所属控制器")]
        [MaxLength(25)]
        public virtual string Controller { get; set; }

        [Display(Name = "模块所属操作")]
        [MaxLength(25)]
        public virtual string Action { get; set; }

        [Display(Name = "模块所属权限ID")]
        public virtual Guid? PermissionGuid { get; set; }

        [Display(Name = "模块所属权限")]
        [ForeignKey("PermissionGuid")]
        public virtual Permission Permission { get; set; }
    }
}
