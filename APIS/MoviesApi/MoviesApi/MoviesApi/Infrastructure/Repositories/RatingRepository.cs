using MoviesApi.Domain;
using MoviesApi.Domain.Contracts;
using MoviesApi.Infrastructure.Postgresql;

namespace MoviesApi.Infrastructure.Repositories
{
    public class RatingRepository : IRating
    {
        private readonly PostgresDbContext _context;
        public RatingRepository(PostgresDbContext context)
        {
            _context = context;
        }
        public Rating AddRating(int idMovie, double rate)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.IdMovie == idMovie) ?? throw new KeyNotFoundException("Movie not found");
            Rating rating = new()
            {
                IdMovie = idMovie,
                Rate = rate,
                Movie = movie
            };
            _context.Ratings.Add(rating);
            _context.SaveChanges();

            rating.Movie = null;
            return rating;
        }
    }
}
