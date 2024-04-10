using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApi.Entities;

namespace Model.Entities
{
    public class ClubPlayers
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }

        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
    }
}
