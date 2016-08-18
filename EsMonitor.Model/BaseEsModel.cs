using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;
using Newtonsoft.Json;

namespace EsMonitor.Model
{
    /// <summary>
    /// 模型类基类
    /// </summary>
    [Serializable]
    public class BaseEsModel : IEsModel
    {
        [Key]
        [Display(Name = "唯一标识符")]
        public virtual Guid Guid { get; set; }

        [NotMapped]
        [Display(Name = "模型状态")]
        public virtual ModelState ModelState { get; set; } = ModelState.UnChanged;

        [NotMapped]
        [Display(Name = "是否新创建对象")]
        public virtual bool IsNew => ModelState == ModelState.Added;

        [JsonIgnore]
        public virtual bool IsDeleted { get; set; }

        [Display(Name = "是否启用")]
        public virtual bool IsEnabled { get; set; }
    }
}
