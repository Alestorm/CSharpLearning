namespace MoviesApi.Controllers.Dtos.MovieDtos
{
    public class NewMovieDto
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public List<string> Genre { get; set; }
    }
}
