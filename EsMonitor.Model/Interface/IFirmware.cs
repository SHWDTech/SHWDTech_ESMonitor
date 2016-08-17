using System.Collections.Generic;

namespace EsMonitor.Model.Interface
{
    public interface IFirmware : ISystemModel
    {
        /// <summary>
        /// 固件名称
        /// </summary>
        string FirmwareName { get; set; }

        /// <summary>
        /// 包含该固件的固件集
        /// </summary>
        ICollection<FirmwareSet> FirmwareSets { get; set; }

        /// <summary>
        /// 固件支持的协议类型
        /// </summary>
        ICollection<Protocol> Protocols { get; set; }
    }
}
