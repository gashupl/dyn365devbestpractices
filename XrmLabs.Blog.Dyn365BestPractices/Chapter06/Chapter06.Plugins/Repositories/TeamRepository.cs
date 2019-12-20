using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Chapter06.Plugins.Repositories.Base; 

namespace Chapter06.Plugins.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public Team GetSalesTeam()
        {
            var query = this.CdsContext.TeamSet.Where<Team>(t => t.Name == "My super sales team");
            return query.FirstOrDefault<Team>();
        }
    }
}
