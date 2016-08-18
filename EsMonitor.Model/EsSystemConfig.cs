using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 系统配置
    /// </summary>
    [Serializable]
    public class EsSystemConfig : BaseEsSystemModel, ISystemEsConfig
    {
        [Required]
        [Display(Name = "系统配置名称")]
        [MaxLength(25)]
        public virtual string Name { get; set; }

        [Required]
        [Display(Name = "系统配置类型")]
        [MaxLength(25)]
        public virtual string Type { get; set; }

        [Required]
        [Display(Name = "系统配置值")]
        [MaxLength(200)]
        public virtual string Value { get; set; }

        [Display(Name = "所属系统配置ID")]
        public virtual Guid? ParentSystemConfigGuid { get; set; }

        [Display(Name = "所属系统配置")]
        [ForeignKey("ParentSystemConfigGuid")]
        public virtual EsSystemConfig ParentEsSystemConfig { get; set; }
    }
}
