using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OneBeyondHackathon.Logic.Storage
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }



        public DbSet<QuoteEntity> Quotes { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
    }
}
