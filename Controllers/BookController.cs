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

    // public async Task<ActionResult<Book>> GetBookAutor (string autor)
    // {
    //     var book = await _context.Books.FindAsync(autor);
    //     if (book == null)
    //     {
    //         return NotFound();
    //     }
        
    //     return book;
    // }

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


    // [HttpPut("{autor}", Name = nameof(GetBookAutor))]

    // public async Task<ActionResult<Book>> Edit(string? autor)
    // {
    //     if (autor == null)
    //     {
    //         return BadRequest("Il n'y a pas d'auteur");
    //     }

    //     // check que le livre existe
    //     var myBook = await _context.Books.FindAsync(autor);
    //     // si oui le mettre a jour 
    //     if (myBook != null) 
    //     {
    //         var test = _context.Update(autor);
    //     } else 
    //     {
    //         return BadRequest("le livre n'existe pas!");
    //     }
    //     // si non tu decides!!!

    //     await _context.SaveChangesAsync();
    //     return myBook;
    // }

    [HttpDelete("{id}", Name = nameof(GetBook))]
    public async Task<ActionResult<string>> Delete(int? Id)
    {
        if (Id == null)
        {
            return BadRequest("Il n'y a pas d'ID");
        }

        // check que le livre existe
        var myBook = await _context.Books.FindAsync(Id);
        // si oui le mettre a jour 
        if (myBook != null) 
        {
            var test = _context.Remove(myBook);
        } else 
        {
            return BadRequest("le livre n'existe pas!");
        }
        // si non tu decides!!!

        await _context.SaveChangesAsync();
        return  "Supprime avec succes!";
    }
}