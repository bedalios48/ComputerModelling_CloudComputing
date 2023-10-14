using Microsoft.AspNetCore.Mvc;

namespace TestAppDT1.Controllers
{
    [ApiController]
    [Route("/")]
    public class LibraryController : ControllerBase
    {
        private readonly ILogger<LibraryController> _logger;
        private readonly ILibrary _library;

        public LibraryController(ILogger<LibraryController> logger, ILibrary library)
        {
            _logger = logger;
            _library = library;
        }

        [HttpGet("GetBooks")]
        public IEnumerable<Book> Get()
        {
            return _library.GetBooks();
        }

        [HttpPost("AddBooks")]
        public IActionResult Post(Book book)
        {
            _library.AddBook(book);
            return Ok();
        }
    }
}