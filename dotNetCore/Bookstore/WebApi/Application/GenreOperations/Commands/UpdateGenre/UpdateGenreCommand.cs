using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApi.Application.GenreOperations.Commands.CommandModels;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommand : IUpdateGenreCommand
    {
        private readonly InMemoryDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateGenreCommand(InMemoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public void Handle(GenreUpdateModel genre)
        {
            var genreIsExist = _dbContext.Genres.AsNoTracking().SingleOrDefault(g=>g.Id==genre.Id);
            if (genreIsExist is null)
            {
                throw new InvalidOperationException("Genre is not Exist !!");
            }
            if (_dbContext.Genres.Any(g => g.Title.ToLower().Equals(genre.Title.ToLower()) && g.Id != genre.Id)) 
            {
                throw new InvalidOperationException("Genre already exist another id !!!");
            }
            if(genre.Title is null)
                genre.Title = genreIsExist.Title;

            genreIsExist = _mapper.Map<Genre>(genre);
            _dbContext.Update(genreIsExist);
            _dbContext.SaveChanges();

        }
    }
}
