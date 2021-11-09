using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;
using WebApi.DbOperations;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommand: IUpdateBookCommand
    {
        private readonly InMemoryDbContext _dbContext;

        public UpdateBookCommand(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(int id, BookInsertModel book)
        {
            var item = _dbContext.Books.SingleOrDefault(b => b.Id == id);
            if (item is null)
                throw new ArgumentNullException("Item is not exist !");

            _dbContext.Remove(item);
            item = new Book();
            item.Id = id;
            item.Title = book.Title;
            item.PageCount = book.PageCount;
            item.GenreId = book.GenreId;
            item.PublishDate = book.PublishDate;
            _dbContext.Books.Add(item);
            _dbContext.SaveChanges();
        }
    }
}
