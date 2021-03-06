﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 图片
    /// </summary>
    [Serializable]
    public class Photo : BaseEsSystemDoaminModel, IPhoto
    {
        [Required]
        [Display(Name = "照片所属设备")]
        public virtual Device PhtotDevice { get; set; }

        [Display(Name = "所属设备")]
        public virtual Guid? DeviceGuid { get; set; }

        [Display(Name = "所属设备")]
        [ForeignKey("DeviceGuid")]
        public virtual Device Device { get; set; }

        [Display(Name = "照片附加信息")]
        public virtual string PhotoTag { get; set; }

        [Required]
        [MaxLength(2000)]
        [Display(Name = "照片地址")]
        public virtual string PhotoUrl { get; set; }

        [Required]
        [Display(Name = "照片类型")]
        public Guid PhotoTypeGuid { get; set; }

        [Display(Name = "照片类型")]
        [ForeignKey("PhotoTypeGuid")]
        public virtual EsSystemDictionary PhotoType { get; set; }
    }
}
