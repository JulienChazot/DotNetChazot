using Microsoft.EntityFrameworkCore;

namespace newWebAPI.Models;

public class AppDbContext : DbContext
{
    //remplacer la connectionstring
    //Comment trouver le serveur de bdd, le nom d'utilisateur et le mot de passe
    private const string DbName = "DBDotNet.db;";

    //configurer EntityFramewordCore (EF 8) pour utiliser le bon SGBD 
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
        var rootFolder = Directory.GetCurrentDirectory();
        var dbPath = Path.Combine(rootFolder, DbName);
        Console.WriteLine(dbPath);
         //configurer EF 8 pour utiliser le bon SGBD
         optionsBuilder.UseSqlite($"Data Source={dbPath}");
     }

    //On va créer une propriété pour chaque table de la BDD
    public DbSet<Book> Books {get; set;}
    public DbSet<Empreint> Empreints {get; set;}
}