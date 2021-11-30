using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Application.BookOperations.Queries.QueryModels;
using WebApi.Application.GenreOperations.Queries.QueryModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.Queries.GetGenre
{
    public class GetGenreQuery : IGetGenreQuery
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetGenreQuery(InMemoryDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public GenreDetailViewModel Handle(int id)
        {
            var genre = _dbContext.Genres.SingleOrDefault(g =>g.IsActive&& g.Id == id);
            if(genre is null) 
            {
                throw new ArgumentNullException("Item is not exist !");
            }
            var viewGenre = _mapper.Map<GenreDetailViewModel>(genre);

            return genreView(viewGenre);
        }
        public GenreDetailViewModel genreView(GenreDetailViewModel genre) 
        {
            var bookList=_dbContext.Books.Where(b=>b.GenreId==genre.Id).ToList();
            var books = _mapper.Map<List<BookViewModel>>(bookList);
            books.ForEach((book) => { genre.Books.Add(book); });
            return genre;
        }

    }
}
