using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Tournament
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null;

        public virtual ICollection<Match> Matches { get; set; }

        public virtual ICollection<Standing> Standings { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }
    }
}
