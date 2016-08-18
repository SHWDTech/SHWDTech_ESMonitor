using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 带有域信息得系统模型基类
    /// </summary>
    [Serializable]
    public class BaseEsSystemDoaminModel : BaseEsSystemModel, ISystemEsDomainModel
    {
        [Required]
        [Display(Name = "所属域ID")]
        public Guid DomainGuid { get; set; }

        [Display(Name = "所属域")]
        [ForeignKey("DomainId")]
        public Domain Domain { get; set; }
    }
}
