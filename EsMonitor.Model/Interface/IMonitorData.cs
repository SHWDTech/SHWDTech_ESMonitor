using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 监测数据模型接口
    /// </summary>
    public interface IMonitorData : IDataModel
    {
        /// <summary>
        /// 数据所属协议包Guid
        /// </summary>
        Guid ProtocolDataGuid { get; set; }

        /// <summary>
        /// 数据所属协议包
        /// </summary>
        ProtocolData ProtocolData { get; set; }

        /// <summary>
        /// 数据类型Guid
        /// </summary>
        Guid CommandDataId { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        CommandData CommandData { get; set; }

        /// <summary>
        /// 数据来源通道号
        /// </summary>
        short DataChannel { get; set; }

        /// <summary>
        /// 来源工地Guid
        /// </summary>
        Guid? ProjectId { get; set; }

        /// <summary>
        /// 来源工地
        /// </summary>
        Project Project { get; set; }

        /// <summary>
        /// 来源设备
        /// </summary>
        Device Device { get; }

        /// <summary>
        /// 来源设备
        /// </summary>
        Guid DeviceId { get; }

        /// <summary>
        /// 数据名称类型
        /// </summary>
        string DataName { get; }

        /// <summary>
        /// 浮点数据值
        /// </summary>
        double? DoubleValue { get; set; }

        /// <summary>
        /// 布尔数据值
        /// </summary>
        bool? BooleanValue { get; set; }

        /// <summary>
        /// 整型数据值
        /// </summary>
        int? IntegerValue { get; set; }

        /// <summary>
        /// 数据上传时间
        /// </summary>
        DateTime UpdateTime { get; set; }

        /// <summary>
        /// 数据是否有效值
        /// </summary>
        bool DataIsValid { get; set; }
    }
}
