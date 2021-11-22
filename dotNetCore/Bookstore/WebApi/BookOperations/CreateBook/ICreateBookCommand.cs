using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;

namespace WebApi.BookOperations.CreateBook
{
    public interface ICreateBookCommand
    {
        void Handle(BookInsertModel book);
    }
}
