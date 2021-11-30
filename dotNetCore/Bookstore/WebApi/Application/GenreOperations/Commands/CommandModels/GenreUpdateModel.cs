namespace WebApi.Application.GenreOperations.Commands.CommandModels
{
    public class GenreUpdateModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
