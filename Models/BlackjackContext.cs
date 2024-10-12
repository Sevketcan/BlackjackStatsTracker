using Microsoft.EntityFrameworkCore;

namespace BlackjackStatsTracker.Models
{
    public class BlackjackContext : DbContext
    {
        public BlackjackContext(DbContextOptions<BlackjackContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
    }
}
