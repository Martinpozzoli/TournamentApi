using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Repository.Data.DataSeed
{
    public class StadiumsSeed : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.HasData(
                new Stadium
                {
                    Id = 1,
                    Name = "Etihad Stadium",
                    Address = "Etihad Campus",
                    Capacity = 55000,
                    City = "Manchester",
                    Country = "England",
                    LocalClubId = 1
                },
                new Stadium
                {
                    Id = 2,
                    Name = "Old Trafford",
                    Address = "Sir Matt Busby Way",
                    Capacity = 75000,
                    City = "Manchester",
                    Country = "England",
                    LocalClubId = 2
                }
            );
        }
    }
}
