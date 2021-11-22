using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;

namespace WebApi.BookOperations.CreateBook
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
