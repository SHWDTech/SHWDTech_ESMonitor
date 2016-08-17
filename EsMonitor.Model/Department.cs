using System;
using System.ComponentModel.DataAnnotations;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 部门模型
    /// </summary>
    [Serializable]
    public class Department : BaseSystemDoaminModel, IDepartment
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "部门名称")]
        public string Name { get; set; }

        [Display(Name = "备注")]
        public string Comment { get; set; }
    }
}
