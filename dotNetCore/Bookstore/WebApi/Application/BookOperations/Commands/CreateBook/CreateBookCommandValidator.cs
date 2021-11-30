using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.BookOperations.Commands.CommandModels;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidator:AbstractValidator<BookInsertModel> 
    {
        public CreateBookCommandValidator()
        {
            RuleFor(command=>command.GenreId).GreaterThan(0);
            RuleFor(command => command.PageCount).GreaterThan(0);
            RuleFor(command => command.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.Title).NotEmpty().MinimumLength(4);
        }
    }
}
