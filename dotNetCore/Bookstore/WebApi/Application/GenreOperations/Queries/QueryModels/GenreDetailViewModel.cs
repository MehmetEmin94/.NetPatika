using System.Collections.Generic;
using WebApi.Application.BookOperations.Queries.QueryModels;

namespace WebApi.Application.GenreOperations.Queries.QueryModels
{
    public class GenreDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
