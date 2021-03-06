﻿namespace EsMonitor.Model.Interface
{
    public interface IDomain : ISystemEsModel
    {
        /// <summary>
        /// 域名称
        /// </summary>
        string DomainName { get; set; }

        /// <summary>
        /// 域类型
        /// </summary>
        string DomianType { get; set; }
    }
}
