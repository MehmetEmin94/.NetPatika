using WebApi.Application.GenreOperations.Commands.CommandModels;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public interface ICreateGenreCommand
    {
        void Handle(GenreInsertModel genre);
    }
}
