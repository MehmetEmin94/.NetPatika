using FluentValidation;
using WebApi.Application.GenreOperations.Commands.CommandModels;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidator: AbstractValidator<GenreInsertModel>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(model => model.Title.Length).GreaterThanOrEqualTo(3);
        }
    }
}
