using Repository.Data;
using Model.Interface;
using Model.Entities;

namespace Repository
{
    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        public MatchRepository(TournamentsDbContext context)
            : base(context)
        {
            // TODO: Add tasks
        }
    }
}
