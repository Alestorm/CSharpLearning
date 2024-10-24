namespace MoviesApi.Controllers.Dtos.MovieDtos
{
    public class MovieDto
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public List<string> Genre { get; set; }
        public double Rating { get; set; } = 0.0;
    }
}
