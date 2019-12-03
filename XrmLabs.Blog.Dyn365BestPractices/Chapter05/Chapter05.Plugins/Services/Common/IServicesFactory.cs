namespace Chapter05.Plugins.Services.Common
{
    public interface IServicesFactory
    {
        T Get<T>() where T : IService; 
    }
}