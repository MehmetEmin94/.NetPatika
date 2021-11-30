namespace WebApi.Application.GenreOperations.Commands.DeleteGenre
{
    public interface IDeleteGenreCommand
    {
        void Handle(int id);
    }
}
