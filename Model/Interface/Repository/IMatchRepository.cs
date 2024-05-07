using Model.Entities;

namespace Model.Interface
{
    public interface IMatchRepository : IRepository<Match>
    {
        Task<Match> SetResult(int id, int score1, int score2);
    }
}
