using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.AuthorOperations.Commands.CommandModels;
using WebApi.Application.BookOperations.Commands.CommandModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand : IUpdateAuthorCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateAuthorCommand(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Handle(AuthorUpdateModel author)
        {
            var item = _dbContext.Authors.AsNoTracking().SingleOrDefault(a => a.Id == author.Id);
            if (item is null)
                throw new ArgumentNullException("Author is not exist !");

            
            item = _mapper.Map<Author>(author);
            
            _dbContext.Update(item);

            _dbContext.SaveChanges();
        }
    }
}
