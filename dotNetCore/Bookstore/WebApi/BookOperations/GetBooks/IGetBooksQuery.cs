using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks.QueryModels;

namespace WebApi.BookOperations.GetBooks
{
    public interface IGetBooksQuery
    {
        List<BookViewModel> Handle();
    }
}
