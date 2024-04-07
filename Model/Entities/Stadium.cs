using System.ComponentModel.DataAnnotations;

namespace TournamentApi.Entities
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
        public int Capacity {  get; set; }    
    }
}
