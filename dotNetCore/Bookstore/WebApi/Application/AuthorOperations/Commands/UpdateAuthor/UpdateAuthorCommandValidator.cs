using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;

namespace WebApi.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateAuthorCommandValidator:AbstractValidator<AuthorUpdateModel>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(updateModel=>updateModel.Id).GreaterThan(0);
            RuleFor(command => command.Name).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Surname).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Birthdate).NotEmpty().LessThan(new DateTime(2010, 1, 1));
        }
    }
}
