using BooksApi.Models;
using BooksApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            Book newBook = _bookRepository.AddBook(book);
            return Created("", newBook);
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookRepository.GetAllBooks());
        }
        [HttpGet("{id}")]
        public IActionResult GetBook([FromRoute] int id)
        {
            Book book = _bookRepository.GetBook(id);
            return Ok(book);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            _bookRepository.DeleteBook(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] Book book)
        {
            var updatedBook = _bookRepository.UpdateBook(id, book);
            return Ok(updatedBook);
        }
    }
}