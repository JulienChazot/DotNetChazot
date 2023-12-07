using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;
using newWebAPI.Models.DTOs;
using newWebAPI.Models.Profiles;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FilmController: ControllerBase
{
    private readonly AppDbContext _context;

    private readonly IMapper _mapper;

    public FilmController(AppDbContext context, IMapper mapper)
    {

        _context = context;
        var cfg = new MapperConfiguration(config => {
            config.AddProfile<AppProfile>();
        });
        var configuration = new MapperConfiguration(cfg => 
        {
            cfg.CreateMap<AppProfile, IMapper>();
        });
        _mapper = mapper;
    }


    [HttpGet]

    public IEnumerable <Film> Get ()
    {
            return _context.Films.ToList();
    }

    [HttpGet]
    public async Task<FilmDetailDTO> GetDetail([FromBody]Film film)
    {
        // tu stockes le retour de la requete dans une vqriqble 
        var listeFilms = await _context.GetFilmDetailsAsync(film.Id);
        // tu mappes ver FilmDetqilDTO et que tu stockes dans une nouvelle vqriqbl 
        var maDTO = _mapper.Map<FilmDetailDTO>(listeFilms);
        return maDTO;
    }

    [HttpGet("{id}", Name = nameof(GetFilm))]
    [ProducesResponseType(200, Type = typeof(FilmDetailDTO))]

    public async Task<ActionResult<Film>> GetFilm (int id)
    {
        var film = await _context.Films.FindAsync(id);
        if (film == null)
        {
            return NotFound();
        }
        
        return film;
    }

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Film))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<Film>> PostBook([FromBody] Film film)
    {
        // we check if the parameter is null
        if (film == null)
        {
            return BadRequest();
        }
        // we check if the book already exists
        Film? addedFilm = await _context.Films.FirstOrDefaultAsync(b => b.Title == film.Title);
        if (addedFilm != null)
        {
            return BadRequest("Film already exists");
        }
        else
        {
            // we add the book to the database
            await _context.Films.AddAsync(film);
            await _context.SaveChangesAsync();

            // we return the book
            return CreatedAtRoute(
                routeName: nameof(GetFilm),
                routeValues: new { id = film.Id },
                value: film);

        }
    }

    [HttpPut("{id}", Name = nameof(GetFilm))]

    public async Task<ActionResult<FilmDetailDTO>> Edit([FromBody]string? autor, int id)
    {
        if (autor == null)
        {
            return BadRequest("Il n'y a pas d'auteur");
        }

        // check que le livre existe
        var myFilm = await _context.Films.FirstOrDefaultAsync(b => b.Autor == autor);
        // si oui le mettre a jour 
        if (myFilm != null) 
        {
            var test = _context.Update(myFilm);
        } else 
        {
            return BadRequest("le film n'existe pas!");
        }
        // si non tu decides!!!

        await _context.SaveChangesAsync();
        return _mapper.Map<FilmDetailDTO>(myFilm);
    }



    [HttpDelete("{id}", Name = nameof(GetFilm))]
    public async Task<ActionResult<string>> Delete(int? id)
    {
        if (id == null)
        {
            return BadRequest("Il n'y a pas d'ID");
        }

        // check que le livre existe
        var myFilm = await _context.Films.FindAsync(id);
        // si oui le mettre a jour 
        if (myFilm != null) 
        {
            var test = _context.Remove(myFilm);
        } else 
        {
            return BadRequest("le film n'éxiste pas");
        }
        // si non tu decides!!!

        await _context.SaveChangesAsync();
        return  "Supprimé avec succès!";
    }
}