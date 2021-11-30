using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Application.AuthorOperations.Commands.CommandModels;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Commands.DeleteAuthor;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.BookOperations.Commands.CommandModels;
using WebApi.Application.BookOperations.Commands.CreateBook;
using WebApi.Application.BookOperations.Commands.DeleteBook;
using WebApi.Application.BookOperations.Commands.UpdateBook;
using WebApi.Application.BookOperations.Queries.GetBook;
using WebApi.Application.BookOperations.Queries.GetBooks;
using WebApi.Application.GenreOperations.Commands.CommandModels;
using WebApi.Application.GenreOperations.Commands.CreateGenre;
using WebApi.Application.GenreOperations.Commands.DeleteGenre;
using WebApi.Application.GenreOperations.Commands.UpdateGenre;
using WebApi.Application.GenreOperations.Queries.GetGenre;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Services;

namespace WebApi.Extensions
{
    public static class DependencyInjectionsExtensions
    {
        public static IServiceCollection AddDependencyInjections(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService, ConsoleLogger>();

            services.AddScoped<IGetBookByIdQuery, GetBookByIdQuery>();
            services.AddScoped<AbstractValidator<BookInsertModel>, CreateBookCommandValidator>();
            services.AddScoped<AbstractValidator<BookUpdateModel>, UpdateBookCommandValidator>();
            services.AddScoped<AbstractValidator<int>, DeleteBookCommandValidator>();
            services.AddScoped<IGetBooksQuery, GetBooksQuery>();
            services.AddScoped<ICreateBookCommand, CreateBookCommand>();
            services.AddScoped<IUpdateBookCommand, UpdateBookCommand>();
            services.AddScoped<IDeleteBookCommand, DeleteBookCommand>();

            services.AddScoped<IGetGenresQuery, GetGenresQuery>();
            services.AddScoped<IGetGenreQuery, GetGenreQuery>();
            services.AddScoped<ICreateGenreCommand, CreateGenreCommand>();
            services.AddScoped<IUpdateGenreCommand, UpdateGenreCommand>();
            services.AddScoped<IDeleteGenreCommand, DeleteGenreCommand>();
            services.AddScoped<AbstractValidator<GenreInsertModel>, CreateGenreCommandValidator>();
            services.AddScoped<AbstractValidator<GenreUpdateModel>, UpdateGenreCommandValidator>();
            services.AddScoped<AbstractValidator<int>, DeleteGenreCommandValidator>();

            services.AddScoped<IGetAuthorsQuery, GetAuthorsQuery>();
            services.AddScoped<IGetAuthorByIdQuery, GetAuthorByIdQuery>();
            services.AddScoped<ICreateAuthorCommand, CreateAuthorCommand>();
            services.AddScoped<IUpdateAuthorCommand, UpdateAuthorCommand>();
            services.AddScoped<IDeleteAuthorCommand, DeleteAuthorCommand>();
            services.AddScoped<AbstractValidator<AuthorInsertModel>, CreateAuthorCommandValidator>();
            services.AddScoped<AbstractValidator<AuthorUpdateModel>, UpdateAuthorCommandValidator>();
            services.AddScoped<AbstractValidator<int>, DeleteAuthorCommandValidator>();

            return services;
        }
    }
}
