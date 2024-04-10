using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Entities
{
    public class Player
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public int Position { get; set; }
        public DateTime BirthDay { get; set; }

        [NotMapped]
        public Club Club { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }
    }
}
