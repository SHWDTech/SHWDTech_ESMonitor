﻿using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 模块模型接口
    /// </summary>
    public interface IModule : ISystemEsDomainModel
    {
        /// <summary>
        /// 父模块Guid
        /// </summary>
        Guid? ParentModuleGuid { get; set; }

        /// <summary>
        /// 父模块
        /// </summary>
        Module ParentModule { get; set; }

        /// <summary>
        /// 是否是菜单项
        /// </summary>
        bool IsMenu { get; set; }

        /// <summary>
        /// 模块所属层级
        /// </summary>
        int ModuleLevel { get; set; }

        /// <summary>
        /// 模块索引
        /// </summary>
        int ModuleIndex { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        string ModuleName { get; set; }

        /// <summary>
        /// 菜单项图标字符串
        /// </summary>
        string IconString { get; set; }

        /// <summary>
        /// 模块所属控制器
        /// </summary>
        string Controller { get; set; }

        /// <summary>
        /// 模块所属操作
        /// </summary>
        string Action { get; set; }

        /// <summary>
        /// 模块关联权限Guid
        /// </summary>
        Guid? PermissionGuid { get; set; }

        /// <summary>
        /// 菜单关联的权限
        /// </summary>
        Permission Permission { get; set; }
    }
}
