using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.QueryModels;
using WebApi.BookOperations.UpdateBook;
using WebApi.BookOperations.GetBook;
using WebApi.BookOperations.DeleteBook;
using FluentValidation;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private readonly IGetBooksQuery _getBooksQuery;
        private readonly IGetBookByIdQuery _getBookByIdQuery;
        private readonly ICreateBookCommand _createBookCommand;
        private readonly IUpdateBookCommand _updateBookCommand;
        private readonly IDeleteBookCommand _deleteBookCommand;
        private readonly AbstractValidator<BookInsertModel> _validateInsert;
        private readonly AbstractValidator<int> _validateById;
        private readonly AbstractValidator<BookUpdateModel> _validateUpdate;

        public BookController(IDeleteBookCommand deleteBookCommand,IGetBooksQuery getBooksQuery, ICreateBookCommand createBookCommand
            , IUpdateBookCommand updateBookCommand, IGetBookByIdQuery getBookByIdQuery, AbstractValidator<BookInsertModel> validateInsert,
            AbstractValidator<int> validateById, AbstractValidator<BookUpdateModel> validateUpdate)
        {
            _deleteBookCommand = deleteBookCommand;
            _getBooksQuery = getBooksQuery;
            _createBookCommand = createBookCommand;
            _updateBookCommand = updateBookCommand;
            _getBookByIdQuery = getBookByIdQuery;
            _validateInsert = validateInsert;
            _validateById = validateById;
            _validateUpdate = validateUpdate;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var bookList = _getBooksQuery.Handle();
            return Ok(bookList);
        }

        [HttpGet("{id}")]
        public IActionResult GetByBookId(int id)
        {
           
            try
            {
                _validateById.ValidateAndThrow(id);
                _getBookByIdQuery.Handle(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            var book = _getBookByIdQuery.Handle(id);
            return Ok(book);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] BookInsertModel book)
        {
            try
            {
                _validateInsert.ValidateAndThrow(book);
                
                //if (!result.IsValid) 
                //{
                //    foreach (var item in result.Errors) 
                //    {
                //        Console.WriteLine("Property "+item.PropertyName+" -- Error Message : "+item.ErrorMessage);
                //    }
                //}
                _createBookCommand.Handle(book);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _validateById.ValidateAndThrow(id);
                _deleteBookCommand.Handle(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] BookUpdateModel book)
        {

            try
            {
                _validateUpdate.ValidateAndThrow(book);
                _updateBookCommand.Handle(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}