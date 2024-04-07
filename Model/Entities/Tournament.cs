using System.ComponentModel.DataAnnotations;

namespace TournamentApi.Entities
{
    public class Tournament
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } = null;
        public List<Club> Clubs { get; set; }
        public static List<Match> Matches { get; set; }
        public static List<Standing> Standings { get; set; }

    }
}