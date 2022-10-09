using Microsoft.EntityFrameworkCore;
using Shop_asp.Models;

namespace Shop_asp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Teams> Teams { get; set; }
        public DbSet<Gamers> Gamers { get; set; }
    }
}
