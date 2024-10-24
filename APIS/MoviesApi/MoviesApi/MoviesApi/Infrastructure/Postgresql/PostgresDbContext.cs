using Microsoft.EntityFrameworkCore;
using MoviesApi.Domain;
using MoviesApi.Infrastructure.Postgresql.ModelConfig;
using MoviesApi.Infrastructure.Postgresql.ModelConfiguration;

namespace MoviesApi.Infrastructure.Postgresql
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
        }

    }
}
