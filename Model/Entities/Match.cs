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

        //    https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key

        public Club LocalTeam { get; set; }

        [ForeignKey(nameof(LocalTeam))]
        public int LocalTeamId { get; set; }


        public Club VisitorTeam { get; set; }

        [ForeignKey(nameof(VisitorTeam))]
        public int VisitorTeamId { get; set; }

        public Stadium Stadium { get; set; }

        [ForeignKey(nameof(Stadium))]
        public int StadiumId { get; set; }
    }
}
