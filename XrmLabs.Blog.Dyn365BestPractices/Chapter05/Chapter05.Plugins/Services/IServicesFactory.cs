namespace Chapter05.Plugins.Services
{
    public interface IServicesFactory
    {
        T Get<T>() where T : IService; 
    }
}