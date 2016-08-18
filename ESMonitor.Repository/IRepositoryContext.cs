using EsMonitor.Model.Interface;

namespace ESMonitor.Repository
{
    public interface IRepositoryContext
    {
        IEsUser CurrentUser { get; set; }

        IDomain CurrentDomain { get; set; }
    }
}
