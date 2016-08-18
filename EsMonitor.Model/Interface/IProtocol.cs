using System;
using System.Collections.Generic;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议接口
    /// </summary>
    public interface IProtocol : ISystemEsModel
    {
        /// <summary>
        /// 协议应用领域Guid
        /// </summary>
        Guid FieldGuid { get; set; }

        /// <summary>
        /// 协议应用领域
        /// </summary>
        EsSystemDictionary Field { get; set; }

        /// <summary>
        /// 协议应用子领域Guid
        /// </summary>
        Guid SubFieldGuid { get; set; }

        /// <summary>
        /// 协议应用子领域
        /// </summary>
        EsSystemDictionary SubField { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        string ProtocolName { get; set; }

        /// <summary>
        /// 协议处理模块
        /// </summary>
        string ProtocolModule { get; set; }

        /// <summary>
        /// 自定义信息
        /// </summary>
        string CustomerInfo { get; set; }

        /// <summary>
        /// 协议版本号
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// 协议头
        /// </summary>
        byte[] Head { get; set; }

        /// <summary>
        /// 协议尾
        /// </summary>
        byte[] Tail { get; set; }

        /// <summary>
        /// 协议的协议结构
        /// </summary>
        ICollection<ProtocolStructure> ProtocolStructures { get; set; }

        /// <summary>
        /// 协议包含的指令
        /// </summary>
        ICollection<ProtocolCommand> ProtocolCommands { get; set; }

        /// <summary>
        /// 协议发布时间
        /// </summary>
        DateTime ReleaseDateTime { get; set; }

        /// <summary>
        /// 校验类型
        /// </summary>
        string CheckType { get; set; }
    }
}
