using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand : ICreateAuthorCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateAuthorCommand(InMemoryDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle(AuthorInsertModel authorInsert)
        {
            var author = _dbContext.Authors.SingleOrDefault(b => b.Name.Equals(authorInsert.Name)&&b.Surname.Equals(authorInsert.Surname));
            if (author is not null)
                throw new InvalidOperationException("Already exist !");

            author = _mapper.Map<Author>(authorInsert);
            _dbContext.Add(author);
            _dbContext.SaveChanges();
        }
    }
}
