using System.Threading;
using EsMonitor.Model.Interface;

namespace ESMonitor.Repository
{
    public class EsMonitorRepository
    {
        public static string ConnectionString { get; set; }

        /// <summary>
        /// 数据仓库上下文
        /// </summary>
        public static IRepositoryContext RepositoryContext 
            => ContextLocal == null ? ContextGlobal : ContextLocal.Value;

        /// <summary>
        /// 当前线程的用户
        /// </summary>
        public static IEsUser CurrentUser => RepositoryContext.CurrentUser;

        /// <summary>
        /// 当前线程用户所属域
        /// </summary>
        public static IDomain CurrentDomain => RepositoryContext.CurrentDomain;

        /// <summary>
        /// 数据仓库上下文线程对象
        /// </summary>
        public static ThreadLocal<IRepositoryContext> ContextLocal { get; set; }

        /// <summary>
        /// 全局数据仓库上下文线程对象
        /// </summary>
        public static IRepositoryContext ContextGlobal { get; set; }

        public static EsMonitorDbContext BaseContext = string.IsNullOrWhiteSpace(ConnectionString)
                                                        ? new EsMonitorDbContext()
                                                        : new EsMonitorDbContext(ConnectionString);
    }
}
