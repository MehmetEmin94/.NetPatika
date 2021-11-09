namespace WebApi.BookOperations.GetBooks.QueryModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string GenreTitle { get; set; }
    }
}
