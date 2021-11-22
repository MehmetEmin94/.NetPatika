﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.QueryModels
{
    public class BookUpdateModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int GenreId { get; set; }

        public int PageCount { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
