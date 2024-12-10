using Microsoft.EntityFrameworkCore;
using SongList.Domain.Entities;
using SongList.Infrastructure.MySqlDatabase.Configuration;

namespace SongList.Infrastructure.MySqlDatabase
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<UserSong> UserSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new UserSongConfiguration());
        }
    }
}
