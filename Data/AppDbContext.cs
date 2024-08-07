using ControleDgn.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ControleDgn.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Padrao> Padrao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dirPath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(dirPath, @"..\..\..\Data\AppDb.db");
            optionsBuilder.UseSqlite($"DataSource={dbPath}");
        }
    }
}
