namespace Chapter04.Plugins.Services
{
    public interface IServicesFactory
    {
        T Get<T>() where T : ServiceBase; 
    }
}