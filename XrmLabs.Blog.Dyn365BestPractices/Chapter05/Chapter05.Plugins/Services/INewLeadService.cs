using Chapter05.Plugins.Services.Common;
using Common.Entities;

namespace Chapter05.Plugins.Services
{
    public interface INewLeadService : IService
    {
        void TryCreateTaskForLargeEmployeesNumberLeads(Lead lead); 
    }
}
