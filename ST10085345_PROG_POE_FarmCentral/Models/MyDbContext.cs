using Microsoft.EntityFrameworkCore;

namespace ST10085345_PROG_POE_FarmCentral.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.useInMemoryDatabase("ProgDb)");
        }
    }
}
