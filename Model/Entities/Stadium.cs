﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Stadium
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Capacity { get; set; }

        public Club LocalClub { get; set; }

        [ForeignKey(nameof(LocalClub))]
        public int LocalClubId { get; set; }
    }
}
