namespace newWebAPI.Models;

public class Empreint
{
    public int Id { get; set;}
    public string? Title { get; set;}
    public string? Autor { get; set;}
    public string? Genre { get; set;}
    public decimal Price { get; set;}
    public DateTime PublishDate { get; set;}
    public string? Description { get; set;}
    public string? Remarks { get; set;}
}