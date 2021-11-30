using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.GenreOperations.Commands.CommandModels;
using WebApi.Application.GenreOperations.Commands.CreateGenre;
using WebApi.Application.GenreOperations.Commands.DeleteGenre;
using WebApi.Application.GenreOperations.Commands.UpdateGenre;
using WebApi.Application.GenreOperations.Queries.GetGenre;
using WebApi.Application.GenreOperations.Queries.GetGenres;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGetGenresQuery _getGenresQuery;
        private readonly IGetGenreQuery _getGenreQuery;
        private readonly ICreateGenreCommand _createGenreCommand;
        private readonly IDeleteGenreCommand _deleteGenreCommand;
        private readonly IUpdateGenreCommand _updateGenreCommand;
        private readonly AbstractValidator<GenreInsertModel> _validateInsert;
        private readonly AbstractValidator<int> _validateById;
        private readonly AbstractValidator<GenreUpdateModel> _validateUpdate;

        public GenresController(IGetGenresQuery getGenresQuery, IGetGenreQuery getGenreQuery, AbstractValidator<GenreInsertModel> validateInsert,
            ICreateGenreCommand createGenreCommand, AbstractValidator<int> validateById, AbstractValidator<GenreUpdateModel> validateUpdate,
            IDeleteGenreCommand deleteGenreCommand, IUpdateGenreCommand updateGenreCommand)
        {
            _getGenresQuery = getGenresQuery;
            _getGenreQuery = getGenreQuery;
            _validateInsert = validateInsert;
            _createGenreCommand = createGenreCommand;
            _validateById = validateById;
            _validateUpdate = validateUpdate;
            _deleteGenreCommand = deleteGenreCommand;
            _updateGenreCommand = updateGenreCommand;
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            var bookList = _getGenresQuery.Handle();
            return Ok(bookList);
        }

        [HttpGet("{id}")]
        public IActionResult GetByGenreId(int id)
        {

            var book = _getGenreQuery.Handle(id);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] GenreInsertModel genre)
        {
            _validateInsert.ValidateAndThrow(genre);

            _createGenreCommand.Handle(genre);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _validateById.ValidateAndThrow(id);
            _deleteGenreCommand.Handle(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] GenreUpdateModel genre)
        {
            _validateUpdate.ValidateAndThrow(genre);
            _updateGenreCommand.Handle(genre);

            return Ok();
        }


    }
}
