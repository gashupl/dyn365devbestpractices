
namespace Chapter06.Plugins.Repositories.Base
{
    public interface ICdsRepositoryFactory
    {
        E GetRepository<E>() where E : class; 

    }
}
