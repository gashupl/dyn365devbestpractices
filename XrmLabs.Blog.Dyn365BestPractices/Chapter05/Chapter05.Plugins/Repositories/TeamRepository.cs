using System.Linq;
using Chapter05.Plugins.Repositories.Common;
using Common.Entities;

namespace Chapter05.Plugins.Repositories
{
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public Team GetSalesTeam()
        { 
            var query = this.ServiceContext.TeamSet.Where<Team>(t => t.Name == "My super sales team");
                return query.FirstOrDefault<Team>(); 
        }
    }
}
