namespace MoviesApi.Domain.Contracts
{
    public interface IMovie
    {
        Movie AddMovie(Movie movie);
        Movie GetMovie(int idMovie);
        List<Movie> GetAllMovies();
    }
}