using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Player
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }
        public DateTime BirthDay { get; set; }
        public Club Club { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }
    }

    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }
}
