using System.ComponentModel.DataAnnotations;

namespace TournamentApi.Entities
{
    public class Club
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<Match> Matches { get; set; }
        public List<Player> Players { get; set; }
        public Standing Standing { get; set; }
    }
}
