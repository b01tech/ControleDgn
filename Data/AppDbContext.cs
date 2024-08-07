using ControleDgn.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDgn.Data
{
    internal class AppDbContext: DbContext
    {
        DbSet<Padrao> Padroes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=Data\AppDb.db");
        }
    }
}
