using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactsApi.Repositories.Database
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.IdUser);
            builder.Property(u => u.Name).HasMaxLength(50);
            builder.Property(u => u.Lastname).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Username).HasMaxLength(50);
            builder.Property(u => u.Password).HasMaxLength(512);
            builder.Property(u => u.Phone).HasMaxLength(23);
        }
    }
}
