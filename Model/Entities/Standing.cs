using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Entities
{
    public class Standing
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [NotMapped]
        public Club Club { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        public int Position { get; set; }
        public int GoalsAgaint { get; set; }
        public int GoalsFor { get; set; }
    }
}
