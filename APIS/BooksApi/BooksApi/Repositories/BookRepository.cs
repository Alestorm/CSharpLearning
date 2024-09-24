using BooksApi.Models;

namespace BooksApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> _books = new List<Book>();
        public Book AddBook(Book book)
        {
            int index = _books.Count + 1;
            _books.Add(book);
            book.IdBook = index;
            return book;
        }

        public void DeleteBook(int idBook)
        {
            var book = _books.FirstOrDefault(b => b.IdBook == idBook);
            if (book != null)
            {
                _books.Remove(book);
            }
            else
            {
                throw new Exception("Book not found");
            }
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBook(int idBook)
        {
            Book book = _books.FirstOrDefault(b => b.IdBook == idBook);
            if (book != null)
            {
                return book;
            }
            else
            {
                throw new Exception("Book not found");
            }
        }

        public Book UpdateBook(int idBook, Book updatedBook)
        {
            Book bookToUpdate = _books.FirstOrDefault(b => b.IdBook == idBook) ?? throw new Exception("Book not found");

            bookToUpdate.Title = updatedBook.Title;
            bookToUpdate.Author = updatedBook.Author;
            bookToUpdate.Publisher = updatedBook.Publisher;
            bookToUpdate.Year = updatedBook.Year;
            bookToUpdate.Genre = updatedBook.Genre;
            bookToUpdate.Language = updatedBook.Language;
            bookToUpdate.PageCount = updatedBook.PageCount;
            return bookToUpdate;
        }
    }
}
