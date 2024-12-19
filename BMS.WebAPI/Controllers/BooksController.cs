namespace BMS.WebAPI.Controllers
{

    using BMS.Application.DTOs;
    using BMS.Application.Interfaces;
    using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _service;


        public BooksController(IBookService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks() => Ok(await _service.GetAllBooksAsync());


        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _service.GetBookByIdAsync(id);
            if (book == null) return NotFound();
            return Ok(book);
        }


        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _service.AddBookAsync(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            if (id != book.Id) return BadRequest();
            await _service.UpdateBookAsync(book);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _service.DeleteBookAsync(id);
            return NoContent();
        }
    }
}