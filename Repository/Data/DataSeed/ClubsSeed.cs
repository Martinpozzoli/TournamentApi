using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Repository.Data.DataSeed
{
    public class ClubsSeed : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.HasData(
                new Club
                {
                    Id = 1,
                    Name = "Manchester City",
                    ShortName = "MCI",
                },
                new Club
                {
                    Id = 2,
                    Name = "Manchester United",
                    ShortName = "MUN",
                },
                new Club
                {
                    Id = 3,
                    Name = "Chelsea",
                    ShortName = "CHE",
                },
                new Club
                {
                    Id = 4,
                    Name = "Liverpool",
                    ShortName = "LIV",
                },
                new Club
                {
                    Id = 5,
                    Name = "Arsenal",
                    ShortName = "ARS",
                },
                new Club
                {
                    Id = 6,
                    Name = "Tottenham Hotspur",
                    ShortName = "TOT",
                },
                new Club
                {
                    Id = 7,
                    Name = "Leicester City",
                    ShortName = "LEI",
                },
                new Club
                {
                    Id = 8,
                    Name = "West Ham United",
                    ShortName = "WHU",
                },
                new Club
                {
                    Id = 9,
                    Name = "Everton",
                    ShortName = "EVE",
                },
                new Club
                {
                    Id = 10,
                    Name = "Aston Villa",
                    ShortName = "AVL",
                },
                new Club
                {
                    Id = 11,
                    Name = "Leeds United",
                    ShortName = "LEE",
                },
                new Club
                {
                    Id = 12,
                    Name = "Wolverhampton Wanderers",
                    ShortName = "WOL",
                },
                new Club
                {
                    Id = 13,
                    Name = "Crystal Palace",
                    ShortName = "CRY",
                },
                new Club
                {
                    Id = 14,
                    Name = "Southampton",
                    ShortName = "SOU",
                },
                new Club
                {
                    Id = 15,
                    Name = "Newcastle United",
                    ShortName = "NEW",
                },
                new Club
                {
                    Id = 16,
                    Name = "Brighton & Hove Albion",
                    ShortName = "BHA",
                },
                new Club
                {
                    Id = 17,
                    Name = "Burnley",
                    ShortName = "BUR",
                },
                new Club
                {
                    Id = 18,
                    Name = "Fulham",
                    ShortName = "FUL",
                },
                new Club
                {
                    Id = 19,
                    Name = "West Bromwich Albion",
                    ShortName = "WBA",
                },
                new Club
                {
                    Id = 20,
                    Name = "Sheffield United",
                    ShortName = "SHU",
                }
            );
        }
    }
}
