using Chapter05.Plugins.Repositories.Common;
using Common.Entities;

namespace Chapter05.Plugins.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        Team GetSalesTeam();
    }
}
