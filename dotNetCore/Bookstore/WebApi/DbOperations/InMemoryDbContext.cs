using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class InMemoryDbContext:DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}