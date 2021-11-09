using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.DeleteBook
{
    public interface IDeleteBookCommand
    {
        void Handle(int id);
    }
}
