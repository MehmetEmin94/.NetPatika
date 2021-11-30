using WebApi.Application.GenreOperations.Commands.CommandModels;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public interface IUpdateGenreCommand
    {
        void Handle(GenreUpdateModel genre);
    }
}
