using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 系统自定义字典
    /// </summary>
    [Serializable]
    public class SystemDictionary : BaseSystemModel, ISystemDictionary
    {
        [Required]
        [Display(Name = "字典名称")]
        public virtual string ItemName { get; set; }

        [Required]
        [Display(Name = "字典项关键字")]
        public virtual string ItemKey { get; set; }

        [Required]
        [Display(Name = "字典项值")]
        public virtual string ItemValue { get; set; }

        [Display(Name = "字典项层级")]
        public virtual byte ItemLevel { get; set; }

        [Display(Name = "父级字典项ID")]
        public virtual Guid? ParentDictionaryGuid { get; set; }

        [Display(Name = "父级字典项")]
        [ForeignKey("ParentDictionaryGuid")]
        public virtual SystemDictionary ParentDictionary { get; set; }
    }
}
