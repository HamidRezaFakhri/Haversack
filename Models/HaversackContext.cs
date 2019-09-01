using Microsoft.EntityFrameworkCore;
namespace HaverSack.Models
{
    public class HaverSackContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Test;Trusted_Connection=False;user id=sa;password=Hrf#9133149941;MultipleActiveResultSets=true;Connection Timeout=30");
        }

        public DbSet<Location> Locations { get; set; }
        
    }
}