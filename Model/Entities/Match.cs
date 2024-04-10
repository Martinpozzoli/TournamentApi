using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Entities
{
    public class Match
    {
        [Key]
        [Required]
        public int Id { get; set; }

        

        public int ScoreTeamA { get; set;}
        public int ScoreTeamB { get; set;}
        public DateTime Date {  get; set; }

        [NotMapped]
        public Club LocalTeam { get; set; }

        [ForeignKey(nameof(Club))]
        public int LocalTeamId { get; set; }

        [NotMapped]
        public Club VisitorTeam { get; set; }

        [ForeignKey(nameof(Club))]
        public int VisitorTeamId { get; set; }

        [NotMapped]
        public Stadium Stadium { get; set; }

        [ForeignKey(nameof(Stadium))]
        public int StadiumId { get; set; }
    }
}
