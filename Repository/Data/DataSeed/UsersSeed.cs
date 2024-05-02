using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Repository.Data.DataSeed
{
    public class UsersSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
              /*
              new User { 
                  Id = 1, 
                  Name = "", 
                  UserName = "", 
                  Password = "",
                  Email = "@mail.com"
              },
              */
              new User
              {
                  Id = 1,
                  Name = "Pepe",
                  UserName = "pepe",
                  Password = "123456",
                  Email = "pepe@mail.com"
              },
              new User
              {
                  Id = 2,
                  Name = "Pepito",
                  UserName = "pepito",
                  Password = "456789",
                  Email = "pepito@mail.com"
              },
              new User
              {
                  Id = 3,
                  Name = "Pepon",
                  UserName = "pepon",
                  Password = "111111",
                  Email = "pepon@mail.com"
              }
            );
        }
    }
}
