using Repository.Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApi.Entities;

namespace Repository
{
    public class TournamentRepository : Repository<Tournament> , ITournamentRepository
    {
        public TournamentRepository(TournamentsDbContext context) : base(context)
        {
            // TODO: Add tasks
        }
    }
}
