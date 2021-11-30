using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand : IDeleteAuthorCommand
    {
        private readonly InMemoryDbContext _dbContext;

        public DeleteAuthorCommand(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(int id)
        {
            var author=_dbContext.Authors.SingleOrDefault(a => a.Id == id);
            if (author is null)
            {
                throw new ArgumentNullException("Author is not exist !");
            }

            var book=_dbContext.Books.SingleOrDefault(b => b.AuthorId == author.Id);

            if (book is not null)
            {
                throw new InvalidOperationException("Author has a book.First delete authors books. !");
            }
            
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
    }
}
