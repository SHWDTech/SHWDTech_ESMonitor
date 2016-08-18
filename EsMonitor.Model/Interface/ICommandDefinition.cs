using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议指令定义接口
    /// </summary>
    public interface ICommandDefinition : ISystemEsModel
    {
        /// <summary>
        /// 所属协议指令Guid
        /// </summary>
        Guid CommandGuid { get; set; }

        /// <summary>
        /// 所属协议指令
        /// </summary>
        ProtocolCommand Command { get; set; }

        /// <summary>
        /// 对应结构名称
        /// </summary>
        string StructureName { get; set; }

        /// <summary>
        /// 定义内容
        /// </summary>
        byte[] ContentBytes { get; set; }
    }
}
