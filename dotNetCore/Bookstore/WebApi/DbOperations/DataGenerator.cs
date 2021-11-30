
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new InMemoryDbContext(serviceProvider.GetRequiredService<DbContextOptions<InMemoryDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange
                (
                   new Book{Title="Dune",GenreId=1,AuthorId=3,PageCount=600,PublishDate=new DateTime(1980,10,10)},
                   new Book{Title="Hobbit",GenreId=2,AuthorId=2,PageCount=800,PublishDate=new DateTime(1995,10,10)},
                   new Book{Title="Clean Code",GenreId=3,AuthorId=1,PageCount=462,PublishDate=new DateTime(2008,01,01)}
                );

                if (context.Genres.Any())
                {
                    return;
                }
                context.Genres.AddRange
                (
                   new Genre { Title = "Science fiction" },
                   new Genre { Title = "Fantastic" },
                   new Genre { Title = "Clean Code" }
                );

                if (context.Authors.Any())
                {
                    return;
                }
                context.Authors.AddRange
                (
                   new Author { Name= "Robert Cecil",Surname="Martin",Birthdate=new DateTime(1960,1,1) },
                   new Author { Name= "J. R. R." ,Surname="Tolkien", Birthdate = new DateTime(1890, 1, 1) },
                   new Author {Name= " Frank",Surname=" Herbert", Birthdate = new DateTime(1910, 1, 1) }
                );
                context.SaveChanges();
            }
        }
    }
}