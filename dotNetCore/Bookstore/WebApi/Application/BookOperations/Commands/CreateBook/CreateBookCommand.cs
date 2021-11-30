using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.BookOperations.Commands.CommandModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommand : ICreateBookCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateBookCommand(InMemoryDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle(BookInsertModel book)
        {
            var item = _dbContext.Books.SingleOrDefault(b => b.Title.Equals(book.Title));
            if (item is not null)
                throw new InvalidOperationException("Already exist !");

            item = _mapper.Map<Book>(book);
            //item.Title = book.Title;
            //item.PageCount = book.PageCount;
            //item.GenreId = book.GenreId;
            //item.PublishDate = book.PublishDate;
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }
    }
}
