using Model.Entities;

namespace TournamentApi.DTO
{
    public class ClubUpdateDTO
    {
        public string ShortName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
