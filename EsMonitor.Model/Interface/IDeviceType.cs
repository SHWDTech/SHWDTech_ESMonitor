using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 设备类型接口
    /// </summary>
    public interface IDeviceType : ISystemEsModel
    {
        /// <summary>
        /// 设备应用领域Guid
        /// </summary>
        Guid FieldGuid { get; set; }

        /// <summary>
        /// 设备应用领域
        /// </summary>
        EsSystemDictionary Field { get; set; }

        /// <summary>
        /// 设备应用子领域Guid
        /// </summary>
        Guid SubFieldGuid { get; set; }

        /// <summary>
        /// 设备应用子领域
        /// </summary>
        EsSystemDictionary SubField { get; set; }

        /// <summary>
        /// 自定义信息
        /// </summary>
        string CustomerInfo { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// 设备发布时间
        /// </summary>
        DateTime ReleaseDateTime { get; set; }

        /// <summary>
        /// 设备类型编码
        /// </summary>
        string DeviceTypeCode { get; set; }
    }
}
