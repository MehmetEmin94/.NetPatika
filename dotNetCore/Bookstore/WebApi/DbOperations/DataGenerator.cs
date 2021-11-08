
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange
                (
                   new Book{Title="Dune",GenreId=1,PageCount=600,PublishDate=new DateTime(1980,10,10)},
                   new Book{Title="Hobbit",GenreId=2,PageCount=800,PublishDate=new DateTime(1995,10,10)},
                   new Book{Title="Clean Code",GenreId=3,PageCount=462,PublishDate=new DateTime(2008,01,01)}
                );
                context.SaveChanges();
            }
        }
    }
}