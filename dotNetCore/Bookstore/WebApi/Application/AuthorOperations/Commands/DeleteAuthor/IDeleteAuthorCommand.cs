using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public interface IDeleteAuthorCommand
    {
        void Handle(int id);
    }
}
