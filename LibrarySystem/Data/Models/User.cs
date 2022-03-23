using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Username { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}
