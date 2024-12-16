namespace BMS.WebAPI.Controllers
{

    using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;


        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "read")]
        public IActionResult GetBookById(int id)
        {
            return Ok();
        }
    }
}