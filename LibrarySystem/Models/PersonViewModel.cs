using LibrarySystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public PersonViewModel() { }

        public PersonViewModel(Person person)
        {
            Id = person.Id;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Address = person.Address;
            Phone = person.Phone;
            Email = person.Email;
        }
    }
}
