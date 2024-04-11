using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Entities
{
    public class Club
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        
    
        public Standing Standing { get; set; }

        [ForeignKey(nameof(Standing))]
        public int StandingId { get; set; }

        [NotMapped]
        public List<Match> Matches { get; set; }  // ClubMatches aux table

        [NotMapped]
        public List<Player> Players { get; set; }  // ClubPlayers aux table
    }
}
