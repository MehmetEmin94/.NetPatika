using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Queries.QueryModels;
using WebApi.Application.BookOperations.Queries.QueryModels;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthor
{
    public class GetAuthorByIdQuery : IGetAuthorByIdQuery
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAuthorByIdQuery(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public AuthorDetailViewModel Handle(int id)
        {
            var author=_dbContext.Authors.SingleOrDefault(a=> a.Id == id);
            if(author is null)
                throw new ArgumentNullException("Item is not exist !");

            var viewModel = _mapper.Map<AuthorDetailViewModel>(author);
            return authorView(viewModel);
        }

        public AuthorDetailViewModel authorView(AuthorDetailViewModel author)
        {
            var bookList = _dbContext.Books.Where(b => b.GenreId == author.Id).ToList();
            var books = _mapper.Map<List<BookViewModel>>(bookList);
            books.ForEach((book) => { author.Books.Add(book); });
            return author;
        }
    }
}
