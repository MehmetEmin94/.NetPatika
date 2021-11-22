using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks.QueryModels;
using WebApi.BookOperations.QueryModels;

namespace WebApi
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookInsertModel,Book>();
            CreateMap<Book, BookViewModel>();
        }
    }
}
