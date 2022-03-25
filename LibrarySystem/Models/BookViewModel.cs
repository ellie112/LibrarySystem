using LibrarySystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }

        public BookViewModel() { }

        public BookViewModel(Book book)
        {
            BookId = book.Id;
            Author = book.Author;
            Title = book.Title;
            Year = book.Year;
        }
    }
}
