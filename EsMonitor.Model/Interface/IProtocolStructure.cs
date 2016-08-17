using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议结构接口
    /// </summary>
    public interface IProtocolStructure : ISystemModel
    {
        /// <summary>
        /// 所属协议Guid
        /// </summary>
        Guid ProtocolGuid { get; set; }

        /// <summary>
        /// 所属协议
        /// </summary>
        Protocol Procotol { get; set; }

        /// <summary>
        /// 协议段数据类型
        /// </summary>
        string DataType { get; set; }

        /// <summary>
        /// 协议段名称
        /// </summary>
        string StructureName { get; set; }

        /// <summary>
        /// 协议段索引值
        /// </summary>
        int StructureIndex { get; set; }

        /// <summary>
        /// 协议段数据长度
        /// </summary>
        int StructureDataLength { get; set; }

        /// <summary>
        /// 协议结构默认值
        /// </summary>
        byte[] DefaultBytes { get; set; }
    }
}
