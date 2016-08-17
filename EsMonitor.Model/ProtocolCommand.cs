﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model
{
    /// <summary>
    /// 协议指令模型
    /// </summary>
    [Serializable]
    public class ProtocolCommand : BaseSystemModel, IProtocolCommand
    {
        [Display(Name = "指令类型编码")]
        public virtual byte[] CommandTypeCode { get; set; }

        [Required]
        [Display(Name = "指令编码")]
        public virtual byte[] CommandCode { get; set; }

        [Required]
        [Display(Name = "指令发送数据长度")]
        public virtual int SendBytesLength { get; set; }

        [Required]
        [Display(Name = "指令数据接收长度")]
        public virtual int ReceiveBytesLength { get; set; }

        [Required]
        [Display(Name = "指令数据接收最大长度")]
        public virtual int ReceiceMaxBytesLength { get; set; }

        [Required]
        [Display(Name = "指令类型")]
        [MaxLength(50)]
        public virtual string CommandCategory { get; set; }

        [Required]
        [Display(Name = "所属协议ID")]
        public virtual Guid ProtocolGuid { get; set; }

        [Display(Name = "所属协议")]
        [ForeignKey("ProtocolGuid")]
        public virtual Protocol Protocol { get; set; }

        [Display(Name = "数据段组合方式")]
        public virtual DataOrderType DataOrderType { get; set; }

        [Display(Name = "指令包含数据")]
        public virtual ICollection<CommandData> CommandDatas { get; set; }

        [Display(Name = "指令定义信息")]
        public virtual ICollection<CommandDefinition> CommandDefinitions { get; set; }
    }
}
