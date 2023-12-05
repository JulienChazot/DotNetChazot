using Microsoft.AspNetCore.Mvc;
using newWebAPI.Models;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BookController: ControllerBase
{
    private readonly AppDbContext _context;

    BookController(AppDbContext context)
    {
        this._context = context;
    }

    [HttpGet]

    public IEnumerable <Book> Get ()
    {
            return _context.Books.ToList();
    }
}