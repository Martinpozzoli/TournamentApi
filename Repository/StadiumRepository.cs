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
    public class StadiumRepository : Repository<Stadium>, IStadiumRepository
    {
        public StadiumRepository(TournamentsDbContext context) : base(context)
        {
            // TODO: Add tasks
        }
    }
}
