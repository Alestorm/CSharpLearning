using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Infrastructure.MySqlDatabase
{
    public class MySqlDbContextFactory : IDesignTimeDbContextFactory<MySqlDbContext>
    {
        public MySqlDbContext CreateDbContext(string[] args)
        {
            string server = "localhost";
            string database = "song_list";
            string user = "root";
            string password = "";

            string connectionString = $"server={server};database={database};user={user};password={password}";

            var optionsBuilder = new DbContextOptionsBuilder<MySqlDbContext>();
            optionsBuilder.UseMySQL(connectionString);
            return new MySqlDbContext(optionsBuilder.Options);
        }
    }
}