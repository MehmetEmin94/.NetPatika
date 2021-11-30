using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Queries.QueryModels;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthor
{
    public interface IGetAuthorByIdQuery
    {
        AuthorDetailViewModel Handle(int id);
    }
}
