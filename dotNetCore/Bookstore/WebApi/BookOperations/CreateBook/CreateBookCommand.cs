using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;
using WebApi.DbOperations;

namespace WebApi.BookOperations.CreateBook
{
    public class CreateBookCommand : ICreateBookCommand
    {
        private readonly InMemoryDbContext _dbContext;

        public CreateBookCommand(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle(BookInsertModel book)
        {
            var item = _dbContext.Books.SingleOrDefault(b => b.Title.Equals(book.Title));
            if (item is not null)
                throw new InvalidOperationException("Already exist !");

            item = new Book();
            item.Title = book.Title;
            item.PageCount = book.PageCount;
            item.GenreId = book.GenreId;
            item.PublishDate = book.PublishDate;
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }
    }
}
