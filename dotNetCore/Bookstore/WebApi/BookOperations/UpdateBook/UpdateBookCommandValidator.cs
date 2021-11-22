using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommandValidator:AbstractValidator<BookUpdateModel>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(updateModel=>updateModel.Id).GreaterThan(0);
            RuleFor(updateModel => updateModel.GenreId).GreaterThan(0);
            RuleFor(updateModel => updateModel.PageCount).GreaterThan(0);
            RuleFor(updateModel => updateModel.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(updateModel => updateModel.Title).NotEmpty().MinimumLength(4);
        }
    }
}
