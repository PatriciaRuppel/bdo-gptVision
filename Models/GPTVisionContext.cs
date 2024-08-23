using Microsoft.EntityFrameworkCore;

namespace bdo.gptVisionApi.Models
{
    public class GPTVisionContext : DbContext
    {
        public GPTVisionContext(DbContextOptions<GPTVisionContext> options) : base(options)
        {
        }

        public DbSet<ChatEntry> ChatEntries { get; set; }
    }
}
