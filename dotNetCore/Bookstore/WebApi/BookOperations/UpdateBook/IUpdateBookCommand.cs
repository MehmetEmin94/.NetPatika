using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.QueryModels;

namespace WebApi.BookOperations.UpdateBook
{
    public interface IUpdateBookCommand
    {
        void Handle(int id,BookInsertModel book);
    }
}
