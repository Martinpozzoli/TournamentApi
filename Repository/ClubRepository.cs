using Repository.Data;
using Repository.Interface;
using TournamentApi.Entities;

namespace Repository
{
    public class ClubRepository : Repository<Club> , IClubRepository
    {
        public ClubRepository(TournamentsDbContext context) : base(context)
        {
            // TODO: Add tasks
        }
    }
}
