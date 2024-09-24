namespace BooksApi.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int PageCount { get; set; }
    }
}
