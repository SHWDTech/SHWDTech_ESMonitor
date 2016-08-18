using System;
using System.Collections.Generic;
using System.Data.Entity;
using EsMonitor.Model.Interface;

namespace ESMonitor.Repository.Repositories
{
    public class SystemDomainRepository<T> : BaseEsMonitorReporitory<T> where T : class, ISystemEsDomainModel, new()
    {
        protected SystemDomainRepository()
        {
            EntityCheckExpression = (obj => obj.DomainGuid == CurrentDomain.Guid);
        }

        protected SystemDomainRepository(DbContext dbContext) : base(dbContext)
        {
            EntityCheckExpression = (obj => obj.DomainGuid == CurrentDomain.Guid);
        }

        public override int AddOrUpdate(T model)
        {
            if (model.DomainGuid == Guid.Empty)
            {
                model.DomainGuid = CurrentDomain.Guid;
            }

            return base.AddOrUpdate(model);
        }

        public override int AddOrUpdate(ICollection<T> models)
        {
            foreach (var model in models)
            {
                if (model.DomainGuid == Guid.Empty)
                {
                    model.DomainGuid = CurrentDomain.Guid;
                }
            }

            return base.AddOrUpdate(models);
        }

        public override int PartialUpdate(T model, ICollection<string> propertyNames)
        {
            if (model.DomainGuid == Guid.Empty)
            {
                model.DomainGuid = CurrentDomain.Guid;
            }

            propertyNames.Add("DomainGuid");

            return base.PartialUpdate(model, propertyNames);
        }

        public override int PartialUpdate(ICollection<T> models, ICollection<string> propertyNames)
        {
            foreach (var model in models)
            {
                if (model.DomainGuid == Guid.Empty)
                {
                    model.DomainGuid = CurrentDomain.Guid;
                }
            }

            propertyNames.Add("DomainGuid");

            return base.PartialUpdate(models, propertyNames);
        }

        public override T ParseModel(string jsonString)
        {
            var model = base.ParseModel(jsonString);
            model.DomainGuid = CurrentDomain.Guid;

            return model;
        }
    }
}
