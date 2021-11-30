using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApi.Application.GenreOperations.Queries.QueryModels;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery: IGetGenresQuery
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetGenresQuery(InMemoryDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<GenreListViewModel> Handle()
        {
            var genres = _dbContext.Genres.Where(g=>g.IsActive).OrderBy(g=>g.Id).ToList();
            var viewGenres=_mapper.Map<List<GenreListViewModel>>(genres);
            return viewGenres;
        }
    }
}
