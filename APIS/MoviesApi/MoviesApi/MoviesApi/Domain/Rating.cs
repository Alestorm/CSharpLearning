namespace MoviesApi.Domain
{
    public class Rating
    {
        public int IdRating { get; set; }
        public double Rate { get; set; }
        public int IdMovie { get; set; }
        public Movie Movie { get; set; }
    }
}