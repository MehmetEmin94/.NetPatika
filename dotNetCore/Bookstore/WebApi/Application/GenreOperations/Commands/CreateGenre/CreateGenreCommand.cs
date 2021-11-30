using AutoMapper;
using System;
using System.Linq;
using WebApi.Application.GenreOperations.Commands.CommandModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommand : ICreateGenreCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateGenreCommand(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Handle(GenreInsertModel genre)
        {
            var genreIsExist = _dbContext.Genres.SingleOrDefault(g => g.Title.ToLower().Equals(genre.Title.ToLower()));
            if(genreIsExist is not null) 
            {
                throw new InvalidOperationException("Already exist !!");
            }
            else
            {
                var createdGenre=_mapper.Map<Genre>(genre);
                _dbContext.Add(createdGenre);
                _dbContext.SaveChanges();
            }
        }
    }
}
