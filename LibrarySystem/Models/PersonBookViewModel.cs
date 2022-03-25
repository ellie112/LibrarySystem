using LibrarySystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class PersonBookViewModel
    {
        public int PersonBookId { get; set; }
        [Required]
        public int BookId { get; set; }
        public BookViewModel Books { get; set; }

        public int PersonId { get; set; }
        public PersonViewModel Person { get; set; }

        [Required]
        public DateTime RentingDate { get; set; }

        public DateTime ReturningDate { get; set; }
        [Required]
        public string Comment { get; set; }

        public PersonBookViewModel() { }

        public PersonBookViewModel(PersonBook personBook)
        {
            PersonBookId = personBook.PersonBookId;
            BookId = personBook.BookId;
            Books = new BookViewModel
            {
                Id = personBook.BookId,
                Author = personBook.Book.Author,
                Title = personBook.Book.Title,
                Year = personBook.Book.Year
            };
            PersonId = personBook.PersonId;
            Person = new PersonViewModel
            {
                Id = personBook.PersonId,
                FirstName = personBook.Person.FirstName,
                LastName = personBook.Person.LastName,
                Address = personBook.Person.Address,
                Phone = personBook.Person.Phone,
                Email = personBook.Person.Email
            };
            RentingDate = personBook.RentingDate;
            ReturningDate = personBook.ReturningDate;
            Comment = personBook.Status;
        }
    }
}
