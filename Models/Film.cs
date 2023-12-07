using System.ComponentModel.DataAnnotations;

namespace newWebAPI.Models;

public class Film : BaseModel
{
    public int Id { get; set;}

    [Required]
    [StringLength(100)]
    public string? Title { get; set;}
    [Required]
    [StringLength(100)]
    public string? Autor { get; set;}

    [StringLength(100)]
    public string? Genre { get; set;}
    [Required]
    [Range(0, 1000)]
    public decimal Price { get; set;}
    public DateTime PublishDate { get; set;}
    public string? Description { get; set;}
    public string? Remarks { get; set;}

    public int Commande {get; set;}
    public int Stock {get; set;}

    [Required]
    public DateTime Duree {get; set;}
}