using System.Collections.Generic;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议指令接口
    /// </summary>
    public interface ICommandData : ISystemEsModel
    {
        /// <summary>
        /// 数据索引值
        /// </summary>
        int DataIndex { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        int DataLength { get; set; }

        /// <summary>
        /// 数据名称
        /// </summary>
        string DataName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        string DataConvertType { get; set; }

        /// <summary>
        /// 数据值类型
        /// </summary>
        DataValueType DataValueType { get; set; }

        /// <summary>
        /// 数据标识
        /// </summary>
        byte DataFlag { get; set; }

        /// <summary>
        /// 所属指令
        /// </summary>
        ICollection<ProtocolCommand> Commands { get; set; }

        /// <summary>
        /// 数据有效性验证位索引
        /// </summary>
        int ValidFlagIndex { get; set; }
    }
}
