using Microsoft.EntityFrameworkCore;
using ProductsMinimalApi.Models;

namespace ProductsMinimalApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}