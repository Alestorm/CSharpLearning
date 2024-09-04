using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.LibraryClasses
{
    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> Books { get; set; }
        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public int CountBooks()
        {
            return Books.Count;
        }
        public void OrderBooksByTitle()
        {
            Console.WriteLine("\n");
            List<Book> ordered = Books.OrderBy(x => x.Title).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine(ordered[i].Title);
                ordered[i].DisplayBookInfo();
            }
        }
        public void OrderBooksByAuthor()
        {
            Console.WriteLine("\n");
            List<Book> ordered = Books.OrderBy(x => x.Author).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine(ordered[i].Author);
                ordered[i].DisplayBookInfo();
            }
        }
        public void OrderBooksByYear()
        {
            Console.WriteLine("\n");
            List<Book> ordered = Books.OrderBy(x => x.Year).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine(ordered[i].Year);
                ordered[i].DisplayBookInfo();
            }
        }
        public void FindByGender(string genre)
        {
            genre = genre.ToLower();
            List<Book> genres = Books.Where(b => b.Genre.ToLower().Equals(genre)).ToList();
            for (int i = 0; i < genres.Count; i++)
            {
                genres[i].DisplayBookInfo();
            }
        }
        public void FindByTitle(string title)
        {
            Book book = Books.Where(b => b.Title.ToLower().Equals(title.ToLower())).FirstOrDefault();
            if (book != null)
            {
                book.DisplayBookInfo();
            }
            else
            {
                Console.WriteLine("Couln't find the book: " + title);
            }
        }
    }
}