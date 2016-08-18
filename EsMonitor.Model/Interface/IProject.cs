using System;

namespace EsMonitor.Model.Interface
{
    /// <summary>
    /// 项目接口
    /// </summary>
    public interface IProject : ISystemEsDomainModel
    {
        /// <summary>
        /// 监测点编号
        /// </summary>
        int StatCode { get; set; }

        /// <summary>
        /// 工程报建号
        /// </summary>
        // ReSharper disable once InconsistentNaming
        string StatBJH { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        string StatName { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        string ChargeMan { get; set; }

        /// <summary>
        /// 负责人电话
        /// </summary>
        string Telephone { get; set; }

        /// <summary>
        /// 项目坐标经度
        /// </summary>
        float? Longitude { get; set; }

        /// <summary>
        /// 项目坐标纬度
        /// </summary>
        float? Latitude { get; set; }

        /// <summary>
        /// 施工单位
        /// </summary>
        string Department { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        string Compnany { get; set; }

        /// <summary>
        /// 项目地址
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// 所属区县
        /// </summary>
        string Country { get; set; }

        /// <summary>
        /// 项目所在街道
        /// </summary>
        string Street { get; set; }

        /// <summary>
        /// 项目所属区域Guid
        /// </summary>
        Guid DistrictGuid { get; set; }

        /// <summary>
        /// 项目所属区域
        /// </summary>
        EsSystemDictionary District { get; set; }

        /// <summary>
        /// 项目占地面积
        /// </summary>
        short Square { get; set; }

        /// <summary>
        /// 项目开始时间
        /// </summary>
        DateTime ProStartDate { get; set; }

        /// <summary>
        /// 施工进展情况
        /// </summary>
        string Stage { get; set; }

        /// <summary>
        /// 项目所属阶段Guid
        /// </summary>
        Guid? ProjectStageGuid { get; set; }

        /// <summary>
        /// 项目所属阶段
        /// </summary>
        EsSystemDictionary ProjectStage { get; set; }

        /// <summary>
        /// 项目类型Guid
        /// </summary>
        Guid? TypeGuid { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        EsSystemDictionary Type { get; set; }

        /// <summary>
        /// 项目报警类型Guid
        /// </summary>
        Guid? AlarmTypeGuid { get; set; }

        /// <summary>
        /// 项目报警类型
        /// </summary>
        EsSystemDictionary AlarmType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        string Comment { get; set; }
    }
}
