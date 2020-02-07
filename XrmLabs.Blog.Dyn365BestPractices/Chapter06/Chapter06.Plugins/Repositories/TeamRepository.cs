using System.Linq;
using Common.Entities;
using Chapter06.Plugins.Repositories.Base;
using Chapter06.Plugins.Common;

namespace Chapter06.Plugins.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(ICdsServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Team GetSalesTeam()
        {
            var query = this.CdsContext.TeamSet.Where<Team>(t => t.Name == "My super sales team");
            return query.FirstOrDefault<Team>();
        }
    }
}
