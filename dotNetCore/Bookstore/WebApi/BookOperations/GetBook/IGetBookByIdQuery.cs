using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks.QueryModels;

namespace WebApi.BookOperations.GetBook
{
    public interface IGetBookByIdQuery
    {
        BookViewModel Handle(int id);
    }
}
