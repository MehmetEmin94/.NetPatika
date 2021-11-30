using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.AuthorOperations.Commands.CommandModels;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Commands.DeleteAuthor;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IGetAuthorsQuery _getAuthorsQuery;
        private readonly IGetAuthorByIdQuery _getAuthorByIdQuery;
        private readonly ICreateAuthorCommand _createAuthorCommand;
        private readonly IUpdateAuthorCommand _updateAuthorCommand;
        private readonly IDeleteAuthorCommand _deleteAuthorCommand;
        private readonly AbstractValidator<AuthorInsertModel> _validateInsert;
        private readonly AbstractValidator<int> _validateById;
        private readonly AbstractValidator<AuthorUpdateModel> _validateUpdate;

        public AuthorsController(AbstractValidator<AuthorUpdateModel> validateUpdate, AbstractValidator<int> validateById, 
            AbstractValidator<AuthorInsertModel> validateInsert, IDeleteAuthorCommand deleteAuthorCommand, IUpdateAuthorCommand updateAuthorCommand,
            ICreateAuthorCommand createAuthorCommand, IGetAuthorByIdQuery getAuthorByIdQuery, IGetAuthorsQuery getAuthorsQuery)
        {
            _validateUpdate = validateUpdate;
            _validateById = validateById;
            _validateInsert = validateInsert;
            _deleteAuthorCommand = deleteAuthorCommand;
            _updateAuthorCommand = updateAuthorCommand;
            _createAuthorCommand = createAuthorCommand;
            _getAuthorByIdQuery = getAuthorByIdQuery;
            _getAuthorsQuery = getAuthorsQuery;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authorList = _getAuthorsQuery.Handle();
            return Ok(authorList);
        }

        [HttpGet("{id}")]
        public IActionResult GetByAuthorId(int id)
        {

            _validateById.ValidateAndThrow(id);
            var author = _getAuthorByIdQuery.Handle(id);
            return Ok(author);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AuthorInsertModel author)
        {
            _validateInsert.ValidateAndThrow(author);

            _createAuthorCommand.Handle(author);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _validateById.ValidateAndThrow(id);
            _deleteAuthorCommand.Handle(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] AuthorInsertModel author)
        {
            AuthorUpdateModel authUpdate = new AuthorUpdateModel { Id = id, Name = author.Name, Surname=author.Surname,Birthdate=author.Birthdate };

            _validateUpdate.ValidateAndThrow(authUpdate);
            _updateAuthorCommand.Handle(authUpdate);

            return Ok();
        }
    }
}
