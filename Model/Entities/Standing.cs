using System.ComponentModel.DataAnnotations;

namespace TournamentApi.Entities
{
    public class Standing
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Club Club { get; set; }
        public int Position { get; set; }
        public int GoalsAgaint { get; set; }
        public int GoalsFor { get; set; }
    }
}
