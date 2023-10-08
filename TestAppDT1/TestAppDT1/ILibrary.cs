namespace TestAppDT1
{
    public interface ILibrary
    {
        void AddBook(Book book);
        IEnumerable<Book> GetBooks();
    }
}