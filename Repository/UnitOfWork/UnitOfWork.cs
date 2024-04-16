using Repository.Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IClubRepository ClubRepository { get; }
        public IMatchRepository MatchRepository { get; }
        public IPlayerRepository PlayerRepository { get; }
        public IStadiumRepository StadiumRepository { get; }
        public ITournamentRepository TournamentRepository { get; }
        public IUserRepository UserRepository { get; }

        private readonly TournamentsDbContext _context;

        public UnitOfWork(TournamentsDbContext context, IClubRepository clubRepository,
            IMatchRepository matchRepository, IPlayerRepository playerRepository, IStadiumRepository stadiumRepository,
            ITournamentRepository tournamentRepository, IUserRepository userRepository)
        {
            _context = context;
            ClubRepository = clubRepository;
            MatchRepository = matchRepository;
            PlayerRepository = playerRepository;
            StadiumRepository = stadiumRepository;
            TournamentRepository = tournamentRepository;
            UserRepository = userRepository;
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
