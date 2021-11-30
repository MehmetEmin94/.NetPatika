using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteAuthorCommandValidator : AbstractValidator<int>
    {
        public DeleteAuthorCommandValidator()
        {
            RuleFor(c => c).GreaterThan(0);
        }
    }
}
