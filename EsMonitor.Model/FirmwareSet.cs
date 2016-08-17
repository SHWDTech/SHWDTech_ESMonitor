﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 固件集
    /// </summary>
    [Serializable]
    public class FirmwareSet : BaseSystemModel, IFirmwareSet
    {
        [Required]
        [Display(Name = "固件集名称")]
        public virtual string FirmwareSetName { get; set; }

        [Required]
        [Display(Name = "固件集包含固件列表")]
        public virtual ICollection<Firmware> Firmwares { get; set; } = new List<Firmware>();
    }
}
