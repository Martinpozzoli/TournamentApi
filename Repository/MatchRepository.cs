using Repository.Data;
using Repository.Interface;
using TournamentApi.Entities;

namespace Repository
{
    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        public MatchRepository(TournamentsDbContext context) : base(context)
        {
            // TODO: Add tasks
        }
    }
}
