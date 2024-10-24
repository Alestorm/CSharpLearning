using ClientAccountApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAccountApi.Infrastructure.MySqlDatabase
{
    public class MySqlDbContext:DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options):base(options)
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Client)
                .WithMany(c => c.Accounts)
                .HasForeignKey(a => a.IdClient)
                .IsRequired();
        }
    }
}
