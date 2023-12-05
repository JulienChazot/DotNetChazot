using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BookController: ControllerBase
{
    private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]

    public IEnumerable <Book> Get ()
    {
            return _context.Books.ToList();
    }

    [HttpGet("{id}", Name = nameof(GetBook))]

    public async Task<ActionResult<Book>> GetBook (int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        
        return book;
    }

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Book))]
    [ProducesResponseType(400)]

    public async Task<ActionResult<Book>> PostBook([FromBody] Book book)
    {
        if (book == null)
        {
            return BadRequest("L'objet book est nul dans le post");
        }
        Book? addedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
        if (addedBook != null)
        {
            return BadRequest("L'objet book existe déjà");
        }
        else {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return CreatedAtRoute(
                routeName: nameof(GetBook),
                routeValues: new { id = book.Id},
                value: book);
            
        }
    }

    // TODO : PUT : api/book/[id] creer la route qui permet de mettre a jour un livre existant
    // TODO: DELETE : api/book/[id] supprimer un livre


}