using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks.DTOs;
using WebApi.BookOperations.GetBooks.QueryModels;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBook
{
    public class GetBookByIdQuery: IGetBookByIdQuery
    {
        private readonly InMemoryDbContext _dbContext;

        public GetBookByIdQuery(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BookViewModel Handle(int id)
        {
            var item=BooksView(id);
            BookViewModel viewModel = new BookViewModel()
                {
                    Title = item.Title,
                    PageCount = item.PageCount,
                    PublishDate = item.PublishDate,
                    GenreTitle = item.GenreTitle
                };
            
            return viewModel;
        }
        public BookViewDto BooksView(int id)
        {
            using (_dbContext)
            {
                var result = from b in _dbContext.Books.Where(b=>b.Id==id)
                             join g in _dbContext.Genres
                             on b.GenreId equals g.Id
                             select new BookViewDto { Title = b.Title, PageCount = b.PageCount, PublishDate = b.PublishDate.ToString("dd/mm/yyyy"), GenreTitle = g.Title };
                return result.Single();
            }
        }
    }
}
