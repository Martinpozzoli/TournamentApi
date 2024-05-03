using Model.Entities;
using System.ComponentModel.DataAnnotations;

namespace TournamentApi.DTO
{
    public class NewClubDTO
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
