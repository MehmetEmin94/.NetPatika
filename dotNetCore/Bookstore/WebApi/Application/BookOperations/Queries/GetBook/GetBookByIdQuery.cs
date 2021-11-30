using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi.Application.BookOperations.Queries.QueryDTOs;
using WebApi.Application.BookOperations.Queries.QueryModels;
using WebApi.DbOperations;

namespace WebApi.Application.BookOperations.Queries.GetBook
{
    public class GetBookByIdQuery: IGetBookByIdQuery
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBookByIdQuery(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public BookViewModel Handle(int id)
        {
            var item=BooksView(id);
            if(item is null)
                throw new ArgumentNullException("Item is not exist !");

            var viewModel = _mapper.Map<BookViewModel>(item);
            return viewModel;
        }
        public BookViewDto BooksView(int id)
        {
                var result = from b in _dbContext.Books.Where(b=>b.Id==id)
                             join g in _dbContext.Genres
                             on b.GenreId equals g.Id
                             select new BookViewDto { Title = b.Title, PageCount = b.PageCount, PublishDate = b.PublishDate.ToString("dd/mm/yyyy"), GenreTitle = g.Title };
                return result.Single();
            
        }
    }
}
