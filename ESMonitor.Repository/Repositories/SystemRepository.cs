using System;
using System.Collections.Generic;
using System.Data.Entity;
using EsMonitor.Model.Interface;

namespace ESMonitor.Repository.Repositories
{
    public class SystemRepository<T> : BaseEsMonitorReporitory<T>, ISystemRepository<T> where T : class, ISystemEsModel, new()
    {
        protected SystemRepository()
        {
            
        }

        protected SystemRepository(DbContext dbContext) : base(dbContext)
        {
            
        }

        public override T ParseModel(string jsonString)
        {
            var model = base.ParseModel(jsonString);
            model.IsEnabled = true;
            model.CreateDateTime = DateTime.Now;
            model.CreateUserGuid = CurrentUser.Guid;

            return model;
        }

        public override int AddOrUpdate(T model)
        {
            model.LastUpdateDateTime = DateTime.Now;
            model.LastUpdateUserGuid = CurrentUser.Guid;

            return base.AddOrUpdate(model);
        }

        public override int AddOrUpdate(ICollection<T> models)
        {
            foreach (var model in models)
            {
                model.LastUpdateDateTime = DateTime.Now;
                model.LastUpdateUserGuid = CurrentUser.Guid;
            }

            return base.AddOrUpdate(models);
        }

        public override void BulkInsert(ICollection<T> models)
        {
            foreach (var model in models)
            {
                model.LastUpdateDateTime = DateTime.Now;
                model.LastUpdateUserGuid = CurrentUser.Guid;
            }
            base.BulkInsert(models);
        }

        public override int PartialUpdate(T model, ICollection<string> propertyNames)
        {
            model.LastUpdateDateTime = DateTime.Now;
            model.LastUpdateUserGuid = CurrentUser.Guid;
            propertyNames.Add("LastUpdateDateTime");
            propertyNames.Add("LastUpdateUserGuid");

            return base.PartialUpdate(model, propertyNames);
        }

        public override int PartialUpdate(ICollection<T> models, ICollection<string> propertyNames)
        {
            foreach (var model in models)
            {
                model.LastUpdateDateTime = DateTime.Now;
                model.LastUpdateUserGuid = CurrentUser.Guid;
            }
            propertyNames.Add("LastUpdateDateTime");
            propertyNames.Add("LastUpdateUserGuid");

            return base.PartialUpdate(models, propertyNames);
        }
    }
}
