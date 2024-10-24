namespace MoviesApi.Domain
{
    public class Movie
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public List<string> Genre { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
