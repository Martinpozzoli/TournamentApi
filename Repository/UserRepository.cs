using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Repository.Data;
using Model.Interface;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TournamentsDbContext context)
            : base(context) { }

        public async Task<User> GetByNamePassword(string user, string password)
        {
            var result = await _context.Users
                .Where(x => x.Password == password && x.UserName == user)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
