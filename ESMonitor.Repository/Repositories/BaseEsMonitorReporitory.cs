using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using EsMonitor.Model.Interface;
using SHWDTech.Repository;
using SHWDTech.Utility;

namespace ESMonitor.Repository.Repositories
{
    public class BaseEsMonitorReporitory<T> : Repository<T> where T : class, IEsModel, new()
    {
        /// <summary>
        /// 当前系统用户
        /// </summary>
        protected IEsUser CurrentUser => EsMonitorRepository.CurrentUser;

        /// <summary>
        /// 当前用户所属域
        /// </summary>
        protected IDomain CurrentDomain => EsMonitorRepository.CurrentDomain;

        protected BaseEsMonitorReporitory()
        {
            
        }

        protected BaseEsMonitorReporitory(DbContext dbContext) : base(dbContext)
        {
            
        }

        public new static T Create()
        {
            var model = Repository<T>.Create();
            if (!Attribute.IsDefined(typeof(T).GetProperty("Guid"), typeof(DatabaseGeneratedAttribute)))
            {
                model.Guid = Globals.NewCombId();
            }

            return model;
        }
            
    }
}
