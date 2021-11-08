using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private readonly BookStoreDbContext _context;
        public BookController(BookStoreDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList=_context.Books.OrderBy(b=>b.Id).ToList();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book GetByBookId(int id)
        {
            var book=_context.Books.FirstOrDefault(b=>b.Id==id);
            return book;
        }
        
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.Books.Remove(_context.Books.FirstOrDefault(b=>b.Id==id));
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Book book)
        {
            _context.Books.Update(_context.Books.FirstOrDefault(b=>b.Id==book.Id));
            _context.SaveChanges();
            return Ok();
        }
    }
}