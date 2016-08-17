using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 用户配置
    /// </summary>
    [Serializable]
    public class UserConfig : BaseSystemDoaminModel, IUserConfig
    {
        [Display(Name = "用户配置名称")]
        [Required]
        [MaxLength(25)]
        public virtual string Name { get; set; }

        [Required]
        [Display(Name = "用户配置类型")]
        [MaxLength(25)]
        public virtual string Type { get; set; }

        [Required]
        [Display(Name = "用户配置值")]
        [MaxLength(200)]
        public virtual string Value { get; set; }

        [Display(Name = "父级用户配置项")]
        public Guid? ParentUserConfigGuid { get; set; }

        [Display(Name = "父级用户配置项")]
        [ForeignKey("ParentUserConfigGuid")]
        public UserConfig ParentUserConfig { get; set; }
    }
}
