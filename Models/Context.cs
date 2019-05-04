using Microsoft.EntityFrameworkCore;

namespace FInalProjectHomekit.Models
{
    public class HomekitDbContext : DbContext
    {
        public HomekitDbContext (DbContextOptions<HomekitDbContext> options)
            : base(options)
        {
        }

        public DbSet<FInalProjectHomekit.Models.Category> Category { get; set; }
        public DbSet<FInalProjectHomekit.Models.Brand> Brand {get; set;}
        public DbSet<FInalProjectHomekit.Models.Product> Product {get; set;}
    }
}