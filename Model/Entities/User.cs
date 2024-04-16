using System.ComponentModel.DataAnnotations;


namespace Model.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
                
        [MaxLength(20)]
        public string? UserName { get; set; }

        [MaxLength(20)]
        public string? Password { get; set; }

        [MaxLength(30)]
        public string? Name { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }
    }
}
