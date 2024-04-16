using Repository.Data;
using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(TournamentsDbContext context)
            : base(context)
        {
            // TODO: Add tasks
        }
    }
}
