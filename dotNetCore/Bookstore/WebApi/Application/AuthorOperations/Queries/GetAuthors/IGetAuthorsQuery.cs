using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Queries.QueryModels;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
    public interface IGetAuthorsQuery
    {
        List<AuthorListViewModel> Handle();
    }
}
