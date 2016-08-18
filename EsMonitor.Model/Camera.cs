using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model
{
    /// <summary>
    /// 摄像头
    /// </summary>
    [Serializable]
    public class Camera : BaseEsSystemDoaminModel, ICamera
    {
        [Display(Name = "摄像头外部ID")]
        [MaxLength(50)]
        public virtual string CameraOutId { get; set; }

        [Display(Name = "摄像头登录名")]
        [MaxLength(25)]
        public virtual string AccessName { get; set; }

        [Display(Name = "摄像头登陆密码")]
        [MaxLength(50)]
        public virtual string AccessPassword { get; set; }

        [Display(Name = "摄像头登录地址")]
        [MaxLength(200)]
        public virtual string AccessUrl { get; set; }

        [Display(Name = "摄像头登陆地址端口号")]
        public virtual int? AccessPort { get; set; }

        [Display(Name = "摄像头登录类型")]
        public virtual Guid? AccessTypeGuid { get; set; }

        [Display(Name = "摄像头登录类型")]
        [ForeignKey("AccessTypeGuid")]
        public virtual EsSystemDictionary AccessType { get; set; }

        [Display(Name = "摄像头所属公司")]
        [MaxLength(50)]
        public virtual string Compnany { get; set; }

        [Display(Name = "摄像头附加信息")]
        [MaxLength(2000)]
        public virtual string ExtraInformation { get; set; }

        [Required]
        [Display(Name = "摄像头状态")]
        public virtual CameraStatus CameraStatus { get; set; }
    }
}
