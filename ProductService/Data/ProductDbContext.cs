using Microsoft.EntityFrameworkCore;

namespace ProductService.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }

    }
}
