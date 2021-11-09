using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks.DTOs;
using WebApi.BookOperations.GetBooks.QueryModels;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery: IGetBooksQuery
    {
        private readonly InMemoryDbContext _dbContext;

        public GetBooksQuery(InMemoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BookViewModel> Handle()
        {
            List<BookViewModel> viewModels = new List<BookViewModel>();
            foreach(var item in BooksView())
            {
                viewModels.Add(new BookViewModel()
                {
                    Title = item.Title,
                    PageCount=item.PageCount,
                    PublishDate=item.PublishDate,
                    GenreTitle=item.GenreTitle
                });
            }
            return viewModels;
        }
        public List<BookViewDto> BooksView(Expression<Func<Book, bool>> filter = null)
        {
            using (_dbContext)
            {
                var result = from b in filter == null ? _dbContext.Books :_dbContext.Books.Where(filter)
                             join g in _dbContext.Genres
                             on b.GenreId equals g.Id
                             select new BookViewDto { Title = b.Title, PageCount = b.PageCount, PublishDate = b.PublishDate.ToString("dd/mm/yyyy"), GenreTitle = g.Title };
                return result.ToList();
            }  
        }
    }
}
