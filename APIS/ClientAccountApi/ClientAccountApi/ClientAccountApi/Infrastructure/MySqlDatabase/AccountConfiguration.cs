using ClientAccountApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientAccountApi.Infrastructure.MySqlDatabase
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.IdAccount);
            builder.Property(a => a.AccountNumber).HasMaxLength(20);
            builder.Property(a=>a.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
