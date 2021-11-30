using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.BookOperations.Commands.CommandModels;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{
    public interface ICreateBookCommand
    {
        void Handle(BookInsertModel book);
    }
}
