using Microsoft.EntityFrameworkCore;
using Model.Entities;
using TournamentApi.Entities;

namespace Repository.Data
{
    public class TournamentsDbContext : DbContext
    {
        public TournamentsDbContext()
        {

        }

        public TournamentsDbContext(DbContextOptions<TournamentsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Data Seed
            //modelBuilder.ApplyConfiguration(new ClubsSeed());
            //modelBuilder.ApplyConfiguration(new MatchesSeed());
            //modelBuilder.ApplyConfiguration(new PlayerssSeed());
            //modelBuilder.ApplyConfiguration(new TournamentsSeed());
            //modelBuilder.ApplyConfiguration(new StadiumsSeed());

            // TODO: Borrar UsersSeed cuando se use JWT
            //modelBuilder.ApplyConfiguration(new UsersSeed());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:ConnectionStringEF");
            optionsBuilder.UseSqlServer(@"Server= DTOP\MSSQLSERVER01;Database=Tournaments_DB; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }

        // TODO: Evaluar si Standings debe ser persistido o si debe ser calculado en consulta
        public virtual DbSet<Standing> Standingss { get; set; }

    }
}
