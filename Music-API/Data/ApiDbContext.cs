using Microsoft.EntityFrameworkCore;
using Music_API.Models;

namespace Music_API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {

        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
