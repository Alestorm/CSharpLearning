using Microsoft.EntityFrameworkCore;
using MoviesApi.Domain;
using MoviesApi.Domain.Contracts;
using MoviesApi.Infrastructure.Postgresql;

namespace MoviesApi.Infrastructure.Repositories
{
    public class MovieRepository : IMovie
    {
        private readonly PostgresDbContext _context;
        public MovieRepository(PostgresDbContext context)
        {
            _context = context;
        }
        public Movie AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.Include(m => m.Ratings).ToList();
        }

        public Movie GetMovie(int idMovie)
        {
            var movie = _context.Movies.Include(m=>m.Ratings).FirstOrDefault(m => m.IdMovie == idMovie) ?? throw new KeyNotFoundException("Movie not found");
            return movie;
        }
    }
}
