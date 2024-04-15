using Repository.Data;
using Model.Interface;
using Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ClubRepository : Repository<Club>, IClubRepository
    {
        public ClubRepository(TournamentsDbContext context)
            : base(context) { }

        public new async Task<List<Club>> GetAll()
        {
            return await _context.Clubs
                .Include(a => a.Players)
                .Include(a => a.Standings)
                .ToListAsync();
        }
    }
}
