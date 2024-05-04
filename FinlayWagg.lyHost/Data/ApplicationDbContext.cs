using FinlayWagg.lyHost.Models;
using Microsoft.EntityFrameworkCore;

namespace FinlayWagg.lyHost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TableColumns> WalkingData { get; set; }
    }
}
