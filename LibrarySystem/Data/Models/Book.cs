using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Author { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Title { get; set; }
        [Required]
        [Range(1000,2022)]
        public string Year { get; set; }
        public virtual ICollection<PersonBook> PersonBooks { get; set; }
    }
}
