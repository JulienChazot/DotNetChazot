using AutoMapper;
using newWebAPI.Models.DTOs;

namespace newWebAPI.Models.Profiles;


public class AppProfile: Profile
{
    public AppProfile()
    {
        CreateMap<Book, BookDetailDTO>().ReverseMap();
        CreateMap<Film, FilmDetailDTO>().ReverseMap();
    }
}