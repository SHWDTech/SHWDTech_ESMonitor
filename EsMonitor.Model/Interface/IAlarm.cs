using System;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 报警信息接口
    /// </summary>
    public interface IAlarm : IDataEsModel
    {
        /// <summary>
        /// 所属设备ID
        /// </summary>
        Guid AlarmDeviceGuid { get; set; }

        /// <summary>
        /// 报警信息所属设备
        /// </summary>
        Device AlarmDevice { get; set; }

        /// <summary>
        /// 报警信息值
        /// </summary>
        double AlarmValue { get; set; }

        /// <summary>
        /// 报警类型
        /// </summary>
        AlarmType AlarmType { get; set; }

        /// <summary>
        /// 报警码
        /// </summary>
        int AlarmCode { get; set; }

        /// <summary>
        /// 数据更新时间
        /// </summary>
        DateTime UpdateTime { get; set; }
    }
}
