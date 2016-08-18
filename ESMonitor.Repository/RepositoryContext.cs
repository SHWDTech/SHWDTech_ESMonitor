using EsMonitor.Model.Interface;

namespace ESMonitor.Repository
{
    public class RepositoryContext : IRepositoryContext
    {
        public IEsUser CurrentUser { get; set; }

        public IDomain CurrentDomain { get; set; }
    }
}
