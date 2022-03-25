using LibrarySystem.Data.Common;
using LibrarySystem.Data.Models;

namespace LibrarySystem.Data
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private Repository<Book> bookRepository;
        private Repository<Person> personRepository;
        private Repository<PersonBook> personBookRepository;
        private Repository<Category> categoryRepository;
        private Repository<Role> roleRepository;
        private Repository<User> userRepository;

        public Repository<Person> PersonRepository
        {
            get
            {

                if (this.personRepository == null)
                {
                    this.personRepository = new Repository<Person>(context);
                }
                return personRepository;
            }
        }

        public Repository<PersonBook> PersonBookRepository
        {
            get
            {

                if (this.personBookRepository == null)
                {
                    this.personBookRepository = new Repository<PersonBook>(context);
                }
                return personBookRepository;
            }
        }
        public Repository<Book> BookRepository
        {
            get
            {

                if (this.bookRepository == null)
                {
                    this.bookRepository = new Repository<Book>(context);
                }
                return bookRepository;
            }
        }
        public Repository<Category> CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new Repository<Category>(context);
                }
                return categoryRepository;
            }
        }
        public Repository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new Repository<User>(context);
                }
                return userRepository;
            }
        }
        public Repository<Role> RoleRepository
        {
            get
            {

                if (this.roleRepository == null)
                {
                    this.roleRepository = new Repository<Role>(context);
                }
                return roleRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
