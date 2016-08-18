using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 指令定义
    /// </summary>
    [Serializable]
    public class CommandDefinition : BaseEsSystemModel, ICommandDefinition
    {
        [Required]
        [Display(Name = "所属指令")]
        public Guid CommandGuid { get; set; }

        [Display(Name = "所属指令")]
        [ForeignKey("CommandGuid")]
        public ProtocolCommand Command { get; set; }

        [Required]
        [Display(Name = "协议结构名称")]
        public string StructureName { get; set; }

        [Display(Name = "指令定义内容")]
        public byte[] ContentBytes { get; set; }
    }
}
