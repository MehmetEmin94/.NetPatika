using FluentValidation;
using WebApi.Application.GenreOperations.Queries.QueryModels;

namespace WebApi.Application.GenreOperations.Queries.GetGenre
{
    public class GetGenreQueryValidator:AbstractValidator<GenreDetailViewModel>
    {
        public GetGenreQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0);
        }
    }
}
