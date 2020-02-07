using Chapter06.Plugins.Commands.Base;
using Chapter06.Plugins.Repositories;
using Common.Entities;

namespace Chapter06.Plugins.Commands
{
    public class TryCreateTaskCommand : CdsCommandBase
    {
        public override bool CanExecute()
        {
            if (this.Context.PrimaryEntityName == Lead.EntityLogicalName && (this.Context.MessageName == "Create" || this.Context.MessageName == "Update"))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public override void Execute()
        {
            var lead = TargetEntity.ToEntity<Lead>(); 

            if (lead.NumberOfEmployees > 30)
            {
                var teamRepository = CdsRepositoryFactory.GetRepository<ITeamRepository>(); 
                var team = teamRepository.GetSalesTeam();
                if (team != null)
                {
                    var taskRepository = CdsRepositoryFactory.GetRepository<ITaskRepository>();
                    taskRepository.Create(new Task()
                    {
                        Subject = "Important lead. Please do sales actions ASAP!",
                        RegardingObjectId = lead.ToEntityReference(),
                        OwnerId = team.ToEntityReference()
                    });
                    taskRepository.SaveChanges();
                }
                else
                {
                    //Log information about missing sales team
                }
            }
        }
    }

}
