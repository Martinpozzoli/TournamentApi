using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.DataSeed
{
    public class StandingsSeed : IEntityTypeConfiguration<Standing>
    {
        public void Configure(EntityTypeBuilder<Standing> builder)
        {
            builder.HasData(
                new Standing
                {
                    Id = 1,
                    ClubId = 1,
                    TournamentId = 1,
                    Position = 1,
                    GoalsFor = 2,
                    GoalsAgainst = 1,
                },
                new Standing
                {
                    Id = 2,
                    ClubId = 2,
                    TournamentId = 1,
                    Position = 10,
                    GoalsFor = 1,
                    GoalsAgainst = 2,
                },
                new Standing
                {
                    Id = 3,
                    ClubId = 3,
                    TournamentId = 1,
                    Position = 2,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 4,
                    ClubId = 4,
                    TournamentId = 1,
                    Position = 3,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 5,
                    ClubId = 5,
                    TournamentId = 1,
                    Position = 4,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 6,
                    ClubId = 6,
                    TournamentId = 1,
                    Position = 5,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 7,
                    ClubId = 7,
                    TournamentId = 1,
                    Position = 6,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 8,
                    ClubId = 8,
                    TournamentId = 1,
                    Position = 7,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 9,
                    ClubId = 9,
                    TournamentId = 1,
                    Position = 8,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 10,
                    ClubId = 10,
                    TournamentId = 1,
                    Position = 9,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 11,
                    ClubId = 1,
                    TournamentId = 2,
                    Position = 1,
                    GoalsFor = 1,
                    GoalsAgainst = 1,
                },
                new Standing
                {
                    Id = 12,
                    ClubId = 15,
                    TournamentId = 2,
                    Position = 3,
                    GoalsFor = 0,
                    GoalsAgainst = 0,
                },
                new Standing
                {
                    Id = 13,
                    ClubId = 16,
                    TournamentId = 2,
                    Position = 2,
                    GoalsFor = 1,
                    GoalsAgainst = 1,
                }
            );
        }
    }
}
