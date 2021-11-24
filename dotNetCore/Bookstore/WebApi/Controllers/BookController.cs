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
           
                _validateById.ValidateAndThrow(id);
            var book = _getBookByIdQuery.Handle(id);
            return Ok(book);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] BookInsertModel book)
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
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
                _validateById.ValidateAndThrow(id);
                _deleteBookCommand.Handle(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] BookInsertModel book)
        {
            BookUpdateModel bookUpdate = new BookUpdateModel { Id = id, GenreId = book.GenreId, PublishDate = book.PublishDate, PageCount = book.PageCount, Title = book.Title };
           
                _validateUpdate.ValidateAndThrow(bookUpdate);
                _updateBookCommand.Handle(bookUpdate);
            
            return Ok();
        }
    }
}