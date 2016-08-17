using System;
using System.Collections.Generic;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议指令模型接口
    /// </summary>
    public interface IProtocolCommand : ISystemModel
    {
        /// <summary>
        /// 指令类型
        /// </summary>
        byte[] CommandTypeCode { get; set; }

        /// <summary>
        /// 指令编码
        /// </summary>
        byte[] CommandCode { get; set; }

        /// <summary>
        /// 指令数据发送长度
        /// </summary>
        int SendBytesLength { get; set; }

        /// <summary>
        /// 指令数据接收长度
        /// </summary>
        int ReceiveBytesLength { get; set; }

        /// <summary>
        /// 指令数据接收最大长度
        /// </summary>
        int ReceiceMaxBytesLength { get; set; }

        /// <summary>
        /// 指令分类
        /// </summary>
        string CommandCategory { get; set; }

        /// <summary>
        /// 所属协议Guid
        /// </summary>
        Guid ProtocolGuid { get; set; }

        /// <summary>
        /// 所属协议
        /// </summary>
        Protocol Protocol { get; set; }

        /// <summary>
        /// 数据段组合方式
        /// </summary>
        DataOrderType DataOrderType { get; set; }

        /// <summary>
        /// 指令数据
        /// </summary>
        ICollection<CommandData> CommandDatas { get; set; }

        /// <summary>
        /// 指令相关定义
        /// </summary>
        ICollection<CommandDefinition> CommandDefinitions { get; set; }
    }
}
