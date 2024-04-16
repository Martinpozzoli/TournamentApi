using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Entities
{
    public class Tournament
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } = null;

        [NotMapped]
        public List<Club> Clubs { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        [NotMapped]
        public static List<Match> Matches { get; set; }

        [ForeignKey(nameof(Match))]
        public int MatchId { get; set; }

        [NotMapped]
        public static List<Standing> Standings { get; set; }

        [ForeignKey(nameof(Standing))]
        public int StandingId { get; set; }
    }
}