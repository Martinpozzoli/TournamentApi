using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IClubRepository ClubRepository { get; }
        public IMatchRepository MatchRepository { get; }
        public IPlayerRepository PlayerRepository { get; }
        public IStadiumRepository StadiumRepository { get; }
        public ITournamentRepository TournamentRepository { get; }
        public IUserRepository UserRepository { get; }


        Task<int> Save();
    }
}
