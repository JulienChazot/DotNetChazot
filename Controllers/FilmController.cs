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
}