using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactsApi.Repositories.Database
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.IdContact);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Lastname).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).HasMaxLength(23);
            builder.Property(c => c.MobileNumber).HasMaxLength(23);
            builder.Property(c => c.Address).HasMaxLength(200);
            builder.Property(c => c.City).HasMaxLength(50);
            builder.Property(c => c.Country).HasMaxLength(50);
            builder.Property(c => c.JobTitle).HasMaxLength(100);
            builder.Property(c => c.DateOfBirth).HasDefaultValue(new DateTime(1900,1,1));
            builder.Property(c => c.Notes).HasMaxLength(200);
        }
    }
}
