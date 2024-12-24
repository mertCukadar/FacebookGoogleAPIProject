using Microsoft.EntityFrameworkCore;
using FacebookGoogleAPIProject.Models;

namespace FacebookGoogleAPIProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AdMetric> AdMetrics { get; set; }
    }
}