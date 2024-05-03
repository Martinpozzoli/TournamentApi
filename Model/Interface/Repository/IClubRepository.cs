using Model.Entities;
using System.Xml.Linq;

namespace Model.Interface
{
    public interface IClubRepository : IRepository<Club>
    {

        Task<List<Club>> GetByName(string name);

        Task<Club> CreateNewClub(string name, string shortName, ICollection<Player> players);

        Task<Club> UpdateClub(string name, string shortName, ICollection<Player> players);

        Task<Club> DeleteClub(string name);
    }
}
