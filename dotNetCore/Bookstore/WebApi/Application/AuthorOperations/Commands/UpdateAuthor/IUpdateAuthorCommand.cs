using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public interface IUpdateAuthorCommand
    {
        void Handle(AuthorUpdateModel author);
    }
}
