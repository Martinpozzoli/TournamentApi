using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApi.Entities;

namespace Model.Entities
{
    public class ClubMatches
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Club Club { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        public Match Match { get; set; }

        [ForeignKey(nameof(Match))]
        public int MatchId { get; set; }
    }
}
