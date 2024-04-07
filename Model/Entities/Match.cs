using System.ComponentModel.DataAnnotations;

namespace TournamentApi.Entities
{
    public class Match
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Club TeamA { get; set;}
        public Club TeamB { get; set;}
        public Club LocalTeam { get; set;}
        public int ScoreTeamA { get; set;}
        public int ScoreTeamB { get; set;}
        public DateTime Date {  get; set; }
        public Stadium Stadium { get; set; }
    }
}
