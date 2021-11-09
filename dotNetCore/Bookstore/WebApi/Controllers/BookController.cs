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
        public BookController(IDeleteBookCommand deleteBookCommand,IGetBooksQuery getBooksQuery, ICreateBookCommand createBookCommand
            , IUpdateBookCommand updateBookCommand, IGetBookByIdQuery getBookByIdQuery)
        {
            _deleteBookCommand = deleteBookCommand;
            _getBooksQuery = getBooksQuery;
            _createBookCommand = createBookCommand;
            _updateBookCommand = updateBookCommand;
            _getBookByIdQuery = getBookByIdQuery;
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
                _deleteBookCommand.Handle(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] BookInsertModel book)
        {

            try
            {
                _updateBookCommand.Handle(id,book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}