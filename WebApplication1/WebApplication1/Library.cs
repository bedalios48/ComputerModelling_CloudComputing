namespace WebApplication1
{
    public class Library : ILibrary
    {
        private List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public IEnumerable<Book> GetBooks() => Books;
    }
}
