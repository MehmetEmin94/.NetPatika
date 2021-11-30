using FluentValidation;
using WebApi.Application.GenreOperations.Commands.CommandModels;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommandValidator:AbstractValidator<GenreUpdateModel>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(model => model.Title).MinimumLength(5).When(m => m.Title.Trim() != string.Empty);
            RuleFor(m => m.Id).GreaterThan(1);
        }
    }
}
