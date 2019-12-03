using Chapter05.Plugins.Repositories;
using Chapter05.Plugins.Repositories.Common;
using Chapter05.Plugins.Services.Common;
using Common.Entities;

namespace Chapter05.Plugins.Services
{
    public class NewLeadService : ServiceBase, INewLeadService
    {
        private readonly ITaskRepository taskRepository;
        private readonly ITeamRepository teamRepository; 
        public NewLeadService(IRepositoryFactory repositoryFactory) : base(repositoryFactory)
        {
            taskRepository = repositoryFactory.Get<Task, ITaskRepository>();
            teamRepository = repositoryFactory.Get<Team, ITeamRepository>();
        }

        public void TryCreateTaskForLargeEmployeesNumberLeads(Lead lead)
        {
            if (lead.NumberOfEmployees > 30)
            {
                var team = teamRepository.GetSalesTeam();
                if (team != null)
                {
                    taskRepository.Create(new Task
                    {
                        Subject = "Important lead. Please do sales actions ASAP!",
                        RegardingObjectId = lead.ToEntityReference(), 
                        OwnerId = team.ToEntityReference()
                    });
                    this.taskRepository.SaveChanges(); 
                }
                else
                {
                    //Log information about missing sales team
                }
            }
        }
    }
}
