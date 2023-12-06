using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;
using newWebAPI.Models.DTOs;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BookController: ControllerBase
{
    private readonly AppDbContext _context;

    private readonly IMapper _mapper;

    public BookController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]

    public IEnumerable <Book> Get ()
    {
            return _context.Books.ToList();
    }

    [HttpGet("{id}", Name = nameof(GetBook))]
    [ProducesResponseType(200, Type = typeof(BookDetailDTO))]

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
        // we check if the parameter is null
        if (book == null)
        {
            return BadRequest();
        }
        // we check if the book already exists
        Book? addedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
        if (addedBook != null)
        {
            return BadRequest("Book already exists");
        }
        else
        {
            // we add the book to the database
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            // we return the book
            return CreatedAtRoute(
                routeName: nameof(GetBook),
                routeValues: new { id = book.Id },
                value: book);

        }
    }
    // TODO: utilisez des annotations pour valider les donnees entrantes avec ModelState
    // TODO: utilisez le package AutoMapper pour mapper les donnees de BookUpdateDTO vers Book

    [HttpPut("{id}", Name = nameof(GetBook))]

    public async Task<ActionResult<Book>> Edit([FromBody]string? autor, int id)
    {
        if (autor == null)
        {
            return BadRequest("Il n'y a pas d'auteur");
        }

        // check que le livre existe
        var myBook = await _context.Books.FirstOrDefaultAsync(b => b.Autor == autor);
        // si oui le mettre a jour 
        if (myBook != null) 
        {
            var test = _context.Update(myBook);
        } else 
        {
            return BadRequest("le livre n'existe pas!");
        }
        // si non tu decides!!!

        await _context.SaveChangesAsync();
        return _mapper.Map<Book>(myBook);
    }



    [HttpDelete("{id}", Name = nameof(GetBook))]
    public async Task<ActionResult<string>> Delete(int? id)
    {
        if (id == null)
        {
            return BadRequest("Il n'y a pas d'ID");
        }

        // check que le livre existe
        var myBook = await _context.Books.FindAsync(id);
        // si oui le mettre a jour 
        if (myBook != null) 
        {
            var test = _context.Remove(myBook);
        } else 
        {
            return BadRequest("le livre n'éxiste pas");
        }
        // si non tu decides!!!

        await _context.SaveChangesAsync();
        return  "Supprimé avec succès!";
    }
}