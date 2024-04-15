using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Repository.Data.DataSeed;

namespace Repository.Data
{
    public class TournamentsDbContext : DbContext
    {
        public TournamentsDbContext() { }

        public TournamentsDbContext(DbContextOptions<TournamentsDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
            // base.OnModelCreating(modelBuilder);
            //Data Seed
            modelBuilder.ApplyConfiguration(new ClubsSeed());
            //modelBuilder.ApplyConfiguration(new MatchesSeed());
            //modelBuilder.ApplyConfiguration(new PlayersSeed());
            modelBuilder.ApplyConfiguration(new TournamentsSeed());
            //modelBuilder.ApplyConfiguration(new StadiumsSeed());
            modelBuilder.ApplyConfiguration(new StandingsSeed());

            // TODO: Borrar UsersSeed cuando se use JWT
            //modelBuilder.ApplyConfiguration(new UsersSeed());

            // Club navigations

            modelBuilder
                .Entity<Club>()
                .HasMany(a => a.Standings)
                .WithOne(a => a.Club)
                .HasForeignKey(a => a.ClubId)
                .HasPrincipalKey(a => a.Id);

            modelBuilder
                .Entity<Club>()
                .HasMany(a => a.Players)
                .WithOne(a => a.Club)
                .HasForeignKey(a => a.ClubId)
                .HasPrincipalKey(a => a.Id);

            // Match navigations

            modelBuilder
                .Entity<Match>()
                .HasOne(a => a.LocalTeam)
                .WithMany(a => a.LocalMatches)
                .HasForeignKey(a => a.LocalTeamId)
                .HasPrincipalKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Match>()
                .HasOne(a => a.VisitorTeam)
                .WithMany(a => a.VisitorMatches)
                .HasForeignKey(a => a.VisitorTeamId)
                .HasPrincipalKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Standing navigations

            modelBuilder
                .Entity<Standing>()
                .HasOne(a => a.Club)
                .WithMany(a => a.Standings)
                .HasForeignKey(a => a.ClubId)
                .HasPrincipalKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Standing>()
                .HasOne(a => a.Tournament)
                .WithMany(a => a.Standings)
                .HasForeignKey(a => a.TournamentId)
                .HasPrincipalKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:ConnectionStringEF");
            //optionsBuilder.UseSqlServer(@"Server= DTOP\MSSQLSERVER01;Database=Tournaments_DB; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }

        // TODO: Evaluar si Standings debe ser persistido o si debe ser calculado en consulta
        public virtual DbSet<Standing> Standings { get; set; }
    }
}
