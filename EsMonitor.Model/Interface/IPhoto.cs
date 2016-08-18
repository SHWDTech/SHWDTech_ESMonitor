using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 图片接口
    /// </summary>
    public interface IPhoto : ISystemEsDomainModel
    {
        /// <summary>
        /// 照片所属设备Guid
        /// </summary>
        Guid? DeviceGuid { get; set; }

        /// <summary>
        /// 照片所属设备
        /// </summary>
        Device Device { get; set; }

        /// <summary>
        /// 照片附加信息
        /// </summary>
        string PhotoTag { get; set; }

        /// <summary>
        /// 照片地址
        /// </summary>
        string PhotoUrl { get; set; }

        /// <summary>
        /// 照片类型ID
        /// </summary>
        Guid PhotoTypeGuid { get; set; }

        /// <summary>
        /// 照片类型
        /// </summary>
        EsSystemDictionary PhotoType { get; set; }
    }
}
