using System.Data.Entity;
using EsMonitor.Model.Interface;

namespace ESMonitor.Repository.Repositories
{
    public class DataReporitory<T> : BaseEsMonitorReporitory<T>, IDataReporitory<T> where T : class, IDataEsModel, new()
    {
        public DataReporitory()
        {
            EntityCheckExpression = (obj => obj.DomainGuid == CurrentDomain.Guid);
        }

        public DataReporitory(DbContext dbContext) : base(dbContext)
        {
            EntityCheckExpression = (obj => obj.DomainGuid == CurrentDomain.Guid);
        }

        public override T ParseModel(string jsonString)
        {
            var model = base.ParseModel(jsonString);
            model.DomainGuid = CurrentDomain.Guid;

            return model;
        }
    }
}
