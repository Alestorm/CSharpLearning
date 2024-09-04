using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.LibraryClasses
{
    public class LibraryMain
    {
        public void Main()
        {
            Library library = new Library("Biblioteca Británica", " 96 Euston Rd., London NW1 2DB");

            #region ADD BOOKS
            library.AddBook(new Book()
            {
                IdBook = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Publisher = "Scribner",
                Year = "1925",
                Genre = "Fiction",
                Language = "English",
                PageCount = 180
            });
            library.AddBook(new Book()
            {
                IdBook = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Publisher = "J.B. Lippincott & Co.",
                Year = "1960",
                Genre = "Fiction",
                Language = "English",
                PageCount = 281
            });
            library.AddBook(new Book()
            {
                IdBook = 3,
                Title = "1984",
                Author = "George Orwell",
                Publisher = "Secker & Warburg",
                Year = "1949",
                Genre = "Science Fiction",
                Language = "English",
                PageCount = 328
            });
            library.AddBook(new Book()
            {
                IdBook = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Publisher = "T. Egerton, Whitehall",
                Year = "1813",
                Genre = "Romance",
                Language = "English",
                PageCount = 279
            });
            library.AddBook(new Book()
            {
                IdBook = 5,
                Title = "It",
                Author = "Stephen King",
                Publisher = "Viking Press",
                Year = "1986",
                Genre = "Horror",
                Language = "English",
                PageCount = 1138
            });
            library.AddBook(new Book()
            {
                IdBook = 6,
                Title = "Death of a Salesman",
                Author = "Arthur Miller",
                Publisher = "Viking Press",
                Year = "1949",
                Genre = "Drama",
                Language = "English",
                PageCount = 144
            });
            library.AddBook(new Book()
            {
                IdBook = 7,
                Title = "A Brief History of Time",
                Author = "Stephen Hawking",
                Publisher = "Bantam Books",
                Year = "1988",
                Genre = "Education",
                Language = "English",
                PageCount = 256
            });
            #endregion

            Console.WriteLine("Library information");
            Console.WriteLine($"Name: {library.Name}");
            Console.WriteLine($"Address: {library.Address}");
            Console.WriteLine($"Number of books in library: {library.CountBooks()}");

            Console.WriteLine($"\n--------- BOOK LIST BY TITLE ---------");
            library.OrderBooksByTitle();

            Console.WriteLine($"\n--------- BOOK LIST BY AUTHOR ---------");
            library.OrderBooksByAuthor();

            Console.WriteLine($"\n--------- BOOK LIST BY YEAR ---------");
            library.OrderBooksByYear();


            string genre = "Fiction";
            Console.WriteLine($"--------- {genre.ToUpper()} BOOKS ---------");
            library.FindByGender(genre);

            genre = "horror";
            Console.WriteLine($"--------- {genre.ToUpper()} BOOKS ---------");
            library.FindByGender(genre);

            string title = "1984";
            library.FindByTitle(title);

            title = "Lord of the rings";
            library.FindByTitle(title);
        }
    }
}