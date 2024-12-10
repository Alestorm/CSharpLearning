using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Infrastructure.MySqlDatabase.Configuration
{
    public class UserSongConfiguration : IEntityTypeConfiguration<UserSong>
    {
        public void Configure(EntityTypeBuilder<UserSong> builder)
        {
            builder.HasKey(us => new { us.IdUser, us.IdSong });

            builder.HasOne(us => us.User)
                .WithMany(u => u.UserSongs)
                .HasForeignKey(u => u.IdUser)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(us => us.Song)
                .WithMany(s => s.UserSongs)
                .HasForeignKey(s => s.IdSong)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
