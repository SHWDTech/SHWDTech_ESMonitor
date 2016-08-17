using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    public class Project : BaseSystemDoaminModel, IProject
    {
        [Display(Name = "负责人")]
        [MaxLength(200)]
        [Required]
        public virtual string ChargeMan { get; set; }

        [Display(Name = "联系电话")]
        [MaxLength(50)]
        [DataType(DataType.PhoneNumber)]
        public virtual string Telephone { get; set; }

        [Display(Name = "经度")]
        public virtual float? Longitude { get; set; }

        [Display(Name = "纬度")]
        public virtual float? Latitude { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "监测点编号")]
        public virtual int StatCode { get; set; }

        [Required]
        [Display(Name = "工程报建号")]
        [MaxLength(20)]
        // ReSharper disable once InconsistentNaming
        public virtual string StatBJH { get; set; }

        [Display(Name = "项目外部编码")]
        [MaxLength(25)]
        public virtual string ProjectOutCode { get; set; }

        [Required]
        [Display(Name = "监测点名称")]
        [MaxLength(20)]
        public virtual string StatName { get; set; }

        [Required]
        [Display(Name = "施工单位")]
        [MaxLength(30)]
        public virtual string Department { get; set; }

        [Display(Name = "项目所属公司")]
        public virtual string Compnany { get; set; }

        [Display(Name = "项目地址")]
        [MaxLength(50)]
        public virtual string Address { get; set; }

        [Display(Name = "所属区县")]
        [MaxLength(20)]
        public virtual string Country { get; set; }

        [Display(Name = "项目所在街道")]
        [MaxLength(20)]
        public virtual string Street { get; set; }

        [Display(Name = "项目所属区域")]
        public virtual Guid DistrictGuid { get; set; }

        [Display(Name = "项目所属区域")]
        [ForeignKey("DistrictGuid")]
        public virtual SystemDictionary District { get; set; }

        [Display(Name = "项目面积")]
        public virtual short Square { get; set; }

        [Display(Name = "工程开始时间")]
        public virtual DateTime ProStartDate { get; set; }

        [Display(Name = "施工进展情况")]
        [MaxLength(20)]
        public string Stage { get; set; }

        [Display(Name = "项目所属阶段")]
        public virtual Guid? ProjectStageGuid { get; set; }

        [Display(Name = "项目所属阶段")]
        [ForeignKey("ProjectStageGuid")]
        public virtual SystemDictionary ProjectStage { get; set; }

        [Display(Name = "项目开始时间")]
        public virtual DateTime StartDate { get; set; }

        [Display(Name = "项目类型")]
        public virtual Guid? TypeGuid { get; set; }

        [Display(Name = "项目类型")]
        [ForeignKey("TypeGuid")]
        public virtual SystemDictionary Type { get; set; }

        [Display(Name = "项目报警类型ID")]
        public virtual Guid? AlarmTypeGuid { get; set; }

        [Display(Name = "项目报警类型")]
        [ForeignKey("AlarmTypeGuid")]
        public virtual SystemDictionary AlarmType { get; set; }

        [Display(Name = "备注")]
        [MaxLength(2000)]
        public virtual string Comment { get; set; }
    }
}
