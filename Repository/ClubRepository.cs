using Repository.Data;
using Model.Interface;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

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

        public async Task<List<Club>> GetByName(string name)
        {
            var clubs = await _context.Clubs.Where(x => x.Name.Contains(name)).ToListAsync();

            return clubs;
        }

        public async Task<Club> CreateNewClub(string name, string shortName, ICollection<Player> players)
        {
            // check for existance
            var club = await _context.Clubs.Where(x => x.Name.Equals(name)).FirstOrDefaultAsync();

            if (club == null && name != "" && shortName != "")
            {
                var newClub = new Club()
                {
                    Name = name,
                    ShortName = shortName,
                    Players = players
                };

                await _context.AddAsync(newClub);
                await _context.SaveChangesAsync();

                return newClub;
            }
            
            return null;
        }


        public async Task<Club> UpdateClub(string name, string shortName, ICollection<Player> players)
        {
            var club = await _context.Clubs.Where(x => x.Name.Equals(name)).FirstOrDefaultAsync();

            if (shortName != "") club.ShortName = shortName;
            if (players.Count != 0) club.Players = players; // Updates complete players collection

            await _context.SaveChangesAsync();

            return club;
        }


        public async Task<Club> DeleteClub(string name)
        {
            var club = await _context.Clubs.Where(x => x.Name.Equals(name)).FirstOrDefaultAsync();

            if (club == null) return null;

            _context.Remove(club);
            await _context.SaveChangesAsync();

            return club;
        }
    }
}
