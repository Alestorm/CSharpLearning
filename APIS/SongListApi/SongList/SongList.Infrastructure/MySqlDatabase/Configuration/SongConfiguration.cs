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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(s => s.IdSong);
            builder.Property(s => s.Title).HasMaxLength(150);
            builder.Property(s => s.Artist).HasMaxLength(150);
            builder.Property(s => s.Album).HasMaxLength(150);
            builder.Property(s => s.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
