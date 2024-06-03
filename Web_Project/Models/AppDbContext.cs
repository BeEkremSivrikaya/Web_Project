using Microsoft.EntityFrameworkCore;

namespace Web_Project.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Ürün> Ürünler { get; set; }

    }
}
