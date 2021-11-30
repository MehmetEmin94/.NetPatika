namespace WebApi.Application.BookOperations.Queries.QueryDTOs
{
    public class BookViewDto
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string GenreTitle { get; set; }
    }
}
