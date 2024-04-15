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
    public class TournamentsSeed : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.HasData(
                new Tournament
                {
                    Id = 1,
                    Name = "Premier League",
                    Description = "English Premier League",
                },
                new Tournament
                {
                    Id = 2,
                    Name = "Mini League",
                    Description = "English Summer League",
                }
            );
        }
    }
}
