using System;
using System.ComponentModel.DataAnnotations;
using EsMonitor.Model.Interface;
using Newtonsoft.Json;

namespace EsMonitor.Model
{
    /// <summary>
    /// 系统模型基类
    /// </summary>
    [Serializable]
    public class BaseEsSystemModel : BaseEsModel, ISystemEsModel
    {
        [JsonIgnore]
        [DataType(DataType.DateTime)]
        public virtual DateTime CreateDateTime { get; set; }

        [JsonIgnore]
        public virtual Guid CreateUserGuid { get; set; }

        [JsonIgnore]
        [DataType(DataType.DateTime)]
        public virtual DateTime? LastUpdateDateTime { get; set; }

        [JsonIgnore]
        public virtual Guid? LastUpdateUserGuid { get; set; }
    }
}
