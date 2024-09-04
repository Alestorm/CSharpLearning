using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.LibraryClasses
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int PageCount { get; set; }

        public void DisplayBookInfo()
        {
            Console.WriteLine("*** Book Information ***");
            Console.WriteLine($"ID: {IdBook}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine("\n");
        }
    }
}
