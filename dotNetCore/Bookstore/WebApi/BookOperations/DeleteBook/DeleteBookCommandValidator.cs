using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.DeleteBook
{
    public class DeleteBookCommandValidator:AbstractValidator<int>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(c => c).GreaterThan(0);
        }
    }
}
