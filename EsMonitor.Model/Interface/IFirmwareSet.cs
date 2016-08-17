using System.Collections.Generic;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 固件集接口
    /// </summary>
    public interface IFirmwareSet : ISystemModel
    {
        /// <summary>
        /// 固件集名称
        /// </summary>
        string FirmwareSetName { get; set; }

        /// <summary>
        /// 固件集包含固件列表
        /// </summary>
        ICollection<Firmware> Firmwares { get; set; }
    }
}
