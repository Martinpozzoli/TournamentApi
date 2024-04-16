using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Repository.Data;
using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StandingRepository : Repository<Standing>, IStandingRepository
    {
        public StandingRepository(TournamentsDbContext context)
            : base(context) { }

        public new async Task<List<Standing>> GetAll()
        {

            return await _context.Standings
                .Include(a => a.Club)
                .Include(a => a.Tournament)
                .ToListAsync();
        }
    }
}
