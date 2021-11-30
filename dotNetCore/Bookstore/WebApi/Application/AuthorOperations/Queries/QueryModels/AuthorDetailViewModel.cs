using System;
using System.Collections.Generic;
using WebApi.Application.BookOperations.Queries.QueryModels;

namespace WebApi.Application.AuthorOperations.Queries.QueryModels
{
    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
