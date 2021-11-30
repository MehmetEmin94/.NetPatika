using System.Collections.Generic;
using WebApi.Application.GenreOperations.Queries.QueryModels;

namespace WebApi.Application.GenreOperations.Queries.GetGenres
{
    public interface IGetGenresQuery
    {
        List<GenreListViewModel> Handle();
    }
}
