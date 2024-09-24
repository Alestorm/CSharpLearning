using BooksApi.Models;

namespace BooksApi.Repositories
{
    public interface IBookRepository
    {
        Book AddBook(Book book);
        List<Book> GetAllBooks();
        Book GetBook(int idBook);
        Book UpdateBook(int idBook, Book book);
        void DeleteBook(int idBook);
    }
}
