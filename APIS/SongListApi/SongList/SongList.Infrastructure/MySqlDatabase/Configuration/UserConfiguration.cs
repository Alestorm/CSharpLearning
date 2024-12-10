using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongList.Domain.Entities;

namespace SongList.Infrastructure.MySqlDatabase.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.IdUser);
            builder.Property(u => u.Username).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Password).HasMaxLength(512);
            builder.Property(u => u.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
