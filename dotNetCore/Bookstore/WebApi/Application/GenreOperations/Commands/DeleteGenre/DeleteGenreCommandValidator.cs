using FluentValidation;

namespace WebApi.Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommandValidator:AbstractValidator<int>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(id => id).NotEmpty().GreaterThan(0);
        }
    }
}
