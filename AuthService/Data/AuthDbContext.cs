using Microsoft.EntityFrameworkCore;

namespace AuthService.Data
{
    public class AuthDbContext:DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options):base(options)
        {
        }
        public DbSet<Models.UserLogin> Users { get; set; }

    }
}
