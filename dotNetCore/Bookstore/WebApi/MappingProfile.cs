using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;
using WebApi.Application.AuthorOperations.Queries.QueryModels;
using WebApi.Application.BookOperations.Commands.CommandModels;
using WebApi.Application.BookOperations.Queries.QueryDTOs;
using WebApi.Application.BookOperations.Queries.QueryModels;
using WebApi.Application.GenreOperations.Commands.CommandModels;
using WebApi.Application.GenreOperations.Queries.QueryModels;
using WebApi.Entities;

namespace WebApi
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookInsertModel,Book>();
            CreateMap<BookUpdateModel,Book>();
            CreateMap<BookViewDto, BookViewModel>();
            CreateMap<Book, BookViewModel>();
            
            CreateMap<Genre,GenreListViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<GenreInsertModel, Genre>();
            CreateMap<GenreUpdateModel, Genre>();

            CreateMap<Author, AuthorListViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();
            CreateMap<AuthorInsertModel, Author>();
            CreateMap<AuthorUpdateModel, Author>();
        }
    }
}
