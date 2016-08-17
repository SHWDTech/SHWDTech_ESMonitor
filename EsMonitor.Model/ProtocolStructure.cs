using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsMonitor.Model.Interface;

namespace EsMonitor.Model
{
    /// <summary>
    /// 协议接口模型类
    /// </summary>
    [Serializable]
    public class ProtocolStructure : BaseSystemModel, IProtocolStructure
    {
        [Required]
        [Display(Name = "所属协议")]
        public virtual Guid ProtocolGuid { get; set; }

        [Display(Name = "所属协议")]
        [ForeignKey("ProtocolGuid")]
        public virtual Protocol Procotol { get; set; }

        [Required]
        [Display(Name = "协议段数据类型")]
        public virtual string DataType { get; set; }

        [Required]
        [Display(Name = "协议段名称")]
        [MaxLength(50)]
        public virtual string StructureName { get; set; }

        [Required]
        [Display(Name = "协议段索引值")]
        public virtual int StructureIndex { get; set; }

        [Required]
        [Display(Name = "协议段数据长度")]
        public virtual int StructureDataLength { get; set; }

        [Required]
        [Display(Name = "协议段默认值")]
        public byte[] DefaultBytes { get; set; }
    }
}
