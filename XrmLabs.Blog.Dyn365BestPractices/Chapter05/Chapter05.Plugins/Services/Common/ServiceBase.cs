using Chapter05.Plugins.Repositories.Common;

namespace Chapter05.Plugins.Services.Common
{
    public abstract class ServiceBase
    {
        protected IRepositoryFactory repositoryFactory; 
        public ServiceBase(IRepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory; 
        }
    }
}
