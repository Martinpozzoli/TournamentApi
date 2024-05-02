using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Repository.Data.DataSeed
{
    public class MatchesSeed : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasData(
                new Match
                {
                    Id = 1,
                    LocalTeamId = 1,
                    VisitorTeamId = 2,
                    ScoreTeamA = 2,
                    ScoreTeamB = 1,
                    Date = new System.DateTime(2021, 10, 1),
                    TournamentId = 1,
                    StadiumId = 1,
                },
                new Match
                {
                    Id = 2,
                    LocalTeamId = 3,
                    VisitorTeamId = 4,
                    ScoreTeamA = 1,
                    ScoreTeamB = 1,
                    Date = new System.DateTime(2021, 10, 2),
                    TournamentId = 1,
                    StadiumId = 2,
                },
                new Match
                {
                    Id = 3,
                    LocalTeamId = 5,
                    VisitorTeamId = 6,
                    Date = new System.DateTime(2024, 10, 3),
                    TournamentId = 2,
                    StadiumId = 1,
                }
            );
        }
    }
}
