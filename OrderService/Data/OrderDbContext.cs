using Microsoft.EntityFrameworkCore;

namespace OrderService.Data
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)
        {
        }
        public DbSet<Models.Order> Orders { get; set; }
    }
}
