using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Standing
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public virtual Tournament Tournament { get; set; }

        [ForeignKey(nameof(Tournament))]
        public int TournamentId { get; set; }

        public int Position { get; set; }

        public virtual Club Club { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        public int GoalsAgainst { get; set; }
        public int GoalsFor { get; set; }
    }
}
