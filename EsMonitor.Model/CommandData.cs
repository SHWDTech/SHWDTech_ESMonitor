﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model
{
    /// <summary>
    /// 指令数据
    /// </summary>
    [Serializable]
    public class CommandData : BaseEsSystemModel, ICommandData
    {
        [Required]
        [Display(Name = "数据索引值")]
        public virtual int DataIndex { get; set; }

        [Required]
        [Display(Name = "数据长度")]
        public virtual int DataLength { get; set; }

        [Required]
        [Display(Name = "数据名称")]
        public virtual string DataName { get; set; }

        [Required]
        [Display(Name = "数据转换类型")]
        public virtual string DataConvertType { get; set; }

        [Required]
        [Display(Name = "数据值类型")]
        public virtual DataValueType DataValueType { get; set; }

        [Display(Name = "数据标识")]
        public virtual byte DataFlag { get; set; }

        [Required]
        [Display(Name = "所属指令")]
        [ForeignKey("CommandGuid")]
        public virtual ICollection<ProtocolCommand> Commands { get; set; }

        [Display(Name = "数据有效性标志位索引值")]
        public int ValidFlagIndex { get; set; } = -1;
    }
}
