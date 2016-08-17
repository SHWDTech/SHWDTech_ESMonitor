using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 数据模型基类
    /// </summary>
    [Serializable]
    public class BaseDataModel : BaseModel, IDataModel
    {
        [Required]
        [Display(Name = "所属域ID")]
        public virtual Guid DomainGuid { get; set; }

        [Display(Name = "所属域")]
        [ForeignKey("DomainId")]
        public virtual Domain Domain { get; set; }
    }
}
