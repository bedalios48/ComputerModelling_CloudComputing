using Microsoft.EntityFrameworkCore;

namespace TestAppDT1
{
    public class Library : ILibrary
    {
        private List<Book> Books = new List<Book>();
        private readonly LibraryContext _context;
        private readonly DbSet<Book> _dbSet;
        public Library(LibraryContext context)
        {
            _context = context;
            _dbSet = _context.Set<Book>();
        }

        public void AddBook(Book book)
        {
            _dbSet.Add(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetBooks() => _dbSet.ToList();
    }
}
