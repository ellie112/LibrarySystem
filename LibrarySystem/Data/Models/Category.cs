using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [Range(0,100)]
        public int SectionNumber { get; set; }
    }
}
