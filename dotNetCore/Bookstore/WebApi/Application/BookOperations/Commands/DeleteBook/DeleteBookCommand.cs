using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommand: IDeleteBookCommand
    {
        private readonly InMemoryDbContext _dbContext;

        public DeleteBookCommand(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(int id)
        {
            var book=_dbContext.Books.SingleOrDefault(b => b.Id == id);
            if (book is null)
                throw new ArgumentNullException("Item is not exist !");
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}
