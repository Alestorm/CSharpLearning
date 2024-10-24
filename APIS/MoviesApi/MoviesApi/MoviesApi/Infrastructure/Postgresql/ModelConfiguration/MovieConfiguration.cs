using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesApi.Domain;

namespace MoviesApi.Infrastructure.Postgresql.ModelConfig
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.IdMovie);
            builder.Property(m=>m.Title).HasMaxLength(200);
            builder.Property(m=>m.Director).HasMaxLength(100);
            builder.HasMany(m => m.Ratings)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.IdMovie);
        }
    }
}
