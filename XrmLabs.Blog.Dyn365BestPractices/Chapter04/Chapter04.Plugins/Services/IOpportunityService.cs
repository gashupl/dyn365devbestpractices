using Common.Entities;

namespace Chapter04.Plugins.Services
{
    public interface IOpportunityService : IService
    {
        void DoSomething(Contact contact); 
    }
}
