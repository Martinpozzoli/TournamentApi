using Model.Entities;

namespace Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByNamePassword(string user, string password);
    }
}
