﻿using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 协议包接口
    /// </summary>
    public interface IProtocolData : IDataEsModel
    {
        /// <summary>
        /// 协议所属设备Guid
        /// </summary>
        Guid DeviceGuid { get; set; }

        /// <summary>
        /// 协议所属设备
        /// </summary>
        Device Device { get; set; }

        /// <summary>
        /// 协议内容
        /// </summary>
        byte[] ProtocolContent { get; set; }

        /// <summary>
        /// 协议内容长度
        /// </summary>
        int Length { get; set; }

        /// <summary>
        /// 协议类型Guid
        /// </summary>
        Guid ProtocolGuid { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        Protocol Protocol { get; set; }

        /// <summary>
        /// 协议包组包完成时间
        /// </summary>
        DateTime ProtocolTime { get; set; }

        /// <summary>
        /// 协议更新时间
        /// </summary>
        DateTime UpdateTime { get; set; }
    }
}
