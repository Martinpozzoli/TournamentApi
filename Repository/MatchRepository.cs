using Repository.Data;
using Model.Interface;
using Model.Entities;

namespace Repository
{
    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        public MatchRepository(TournamentsDbContext context)
            : base(context) { }

        public async Task<Match> SetResult(int id, int score1, int score2)
        {
            var match = await _context.Matches.FindAsync(id);
            match.ScoreTeamA = score1;
            match.ScoreTeamB = score2;
            await _context.SaveChangesAsync();
            return match;
        }
    }
}
