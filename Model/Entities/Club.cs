using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Club
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }
        public virtual ICollection<Standing> Standings { get; set; }

        public virtual ICollection<Match> LocalMatches { get; set; }

        public virtual ICollection<Match> VisitorMatches { get; set; }

        public virtual ICollection<Player> Players { get; set; } // ClubPlayers aux table
    }
}
