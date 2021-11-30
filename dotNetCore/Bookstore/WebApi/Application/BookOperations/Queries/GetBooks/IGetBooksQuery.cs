using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.BookOperations.Queries.QueryModels;

namespace WebApi.Application.BookOperations.Queries.GetBooks
{
    public interface IGetBooksQuery
    {
        List<BookViewModel> Handle();
    }
}
