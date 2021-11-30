using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Queries.QueryModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorsQuery : IGetAuthorsQuery
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAuthorsQuery(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<AuthorListViewModel> Handle()
        {
            var authors=_dbContext.Authors.ToList();
             var viewModel = _mapper.Map<List<AuthorListViewModel>>(authors);
            return viewModel;
        }
    }
}
