using WebApi.Application.GenreOperations.Queries.QueryModels;

namespace WebApi.Application.GenreOperations.Queries.GetGenre
{
    public interface IGetGenreQuery
    {
        GenreDetailViewModel Handle(int id);
    }
}
