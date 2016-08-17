﻿using System;
using EsMonitor.Model.ModelEnums;

namespace EsMonitor.Model.Interface
{
    public interface IModel
    {
        /// <summary>
        /// 数据唯一标识符
        /// </summary>
        Guid Guid { get; set; }

        /// <summary>
        /// 模型状态
        /// </summary>
        ModelState ModelState { get; set; }
    }
}
