using AutoMapper;
using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommand : IDeleteGenreCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;

        public DeleteGenreCommand(IMapper mapper, InMemoryDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public void Handle(int id)
        {
            var genreIsExist = _dbContext.Genres.SingleOrDefault(g=>g.Id==id);
            if (genreIsExist is not null)
            {
                _dbContext.Genres.Remove(genreIsExist);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Genre is not exist !!!");
            }
        }
    }
}
