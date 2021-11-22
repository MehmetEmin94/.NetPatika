using AutoMapper;
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
        private readonly IMapper _mapper;

        public UpdateBookCommand(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Handle(BookUpdateModel book)
        {
            var item = _dbContext.Books.SingleOrDefault(b => b.Id == book.Id);
            if (item is null)
                throw new ArgumentNullException("Item is not exist !");

            _dbContext.Remove(item);
            item = _mapper.Map<Book>(book);
            
            _dbContext.Books.Add(item);
            _dbContext.SaveChanges();
        }
    }
}
