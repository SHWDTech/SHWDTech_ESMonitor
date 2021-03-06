﻿using System;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 摄像头接口
    /// </summary>
    public interface ICamera : ISystemEsDomainModel
    {
        /// <summary>
        /// 摄像头外部ID
        /// </summary>
        string CameraOutId { get; set; }

        /// <summary>
        /// 摄像头登录名
        /// </summary>
        string AccessName { get; set; }

        /// <summary>
        /// 摄像头登录密码
        /// </summary>
        string AccessPassword { get; set; }

        /// <summary>
        /// 摄像头登录地址
        /// </summary>
        string AccessUrl { get; set; }

        /// <summary>
        /// 摄像头登陆端口
        /// </summary>
        int? AccessPort { get; set; }

        /// <summary>
        /// 摄像头登录类型Guid
        /// </summary>
        Guid? AccessTypeGuid { get; set; }

        /// <summary>
        /// 摄像头登录类型
        /// </summary>
        EsSystemDictionary AccessType { get; set; }

        /// <summary>
        /// 摄像头所属公司
        /// </summary>
        string Compnany { get; set; }

        /// <summary>
        /// 摄像头附加信息
        /// </summary>
        string ExtraInformation { get; set; }

        /// <summary>
        /// 摄像头状态
        /// </summary>
        CameraStatus CameraStatus { get; set; }
    }
}
