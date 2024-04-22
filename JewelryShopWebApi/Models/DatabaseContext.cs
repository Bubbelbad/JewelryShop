using Microsoft.EntityFrameworkCore;

namespace JewelryShopWebApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options) { }

    }
}
