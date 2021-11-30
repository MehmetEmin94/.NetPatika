using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{
    public class CreateAuthorCommandValidator : AbstractValidator<AuthorInsertModel> 
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command=>command.Name).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Surname).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Birthdate).NotEmpty().LessThan(new DateTime(2010,1,1));
        }
    }
}
