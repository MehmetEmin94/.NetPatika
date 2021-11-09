using Microsoft.EntityFrameworkCore;

namespace WebApi.DbOperations
{
    public class InMemoryDbContext:DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }


    }
}