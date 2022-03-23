using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Data.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Range(0, 127)]
        public byte Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public virtual ICollection<PersonBook> PersonBooks { get; set; }
    }
}
