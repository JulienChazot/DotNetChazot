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

     

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "Professional C# 6 and .NET Core 1.0",
                Autor = "Christian Nagel",
                Description = "A true masterclass in C# and .NET programming",
                Genre = "Software",
                Price = 50,
                PublishDate = new DateTime(2016, 05, 09)
            },
            new Book
            {
                Id = 2,
                Title = "Professional C# 7 and .NET Core 2.0",
                Autor = "Christian Nagel",
                Description = "A true masterclass in C# and .NET programming",
                Genre = "Software",
                Price = 50,
                PublishDate = new DateTime(2018, 04, 18)
            },
            new Book
            {
                Id = 3,
                Title = "Professional C# 8 and .NET Core 3.0",
                Autor = "Christian Nagel",
                Description = "A true masterclass in C# and .NET programming",
                Genre = "Software",
                Price = 50,
                PublishDate = new DateTime(2019, 10, 30)
            },
            new Book
            {
                Id = 4,
                Title = "Professional C# 9 and .NET 5",
                Autor = "Christian Nagel",
                Description = "A true masterclass in C# and .NET programming",
                Genre = "Software",
                Price = 50,
                PublishDate = new DateTime(2021, 01, 01)
            },
            new Book
            {
                Id = 5,
                Title = "Beginning Visual C# 2019",
                Autor = "Perkins, Reid, and Hammer",
                Description = "The perfect guide to Visual C#",
                Genre = "Software",
                Price = 45,
                PublishDate = new DateTime(2020, 09, 23)
            },
            new Book
            {
                Id = 6,
                Title = "Pro C# 7",
                Autor = "Andrew Troelsen",
                Description = "The ultimate C# resource",
                Genre = "Software",
                Price = 50,
                PublishDate = new DateTime(2017, 10, 01)
            });

            modelBuilder.Entity<Film>().HasData(
                new Film{
                    Id = 1,
                    Title = "Mon Premier Film",
                    Autor = "MonPremierAuteur",
                    Description = "Pas mal",
                    Genre = "Animé",
                    Price = 15,
                    PublishDate = new DateTime(2017, 10, 01),
                    Commande = 20,
                    Stock = 3,
                    Duree = new DateTime (2017, 10 ,2)
                },
                new Film{
                    Id = 2,
                    Title = "Mon Deuxieme Film",
                    Autor = "MonDeuxiemeAuteur",
                    Description = "Tres bien",
                    Genre = "Animé",
                    Price = 15,
                    PublishDate = new DateTime(2012, 10, 01),
                    Commande = 5,
                    Stock = 1,
                    Duree = new DateTime (2014, 10 ,2)
                },
                new Film{
                    Id = 3,
                    Title = "Mon Troisieme Film",
                    Autor = "MonTroisiemeAuteur",
                    Description = "OK",
                    Genre = "Action",
                    Price = 35,
                    PublishDate = new DateTime(2017, 08, 01),
                    Commande = 28,
                    Stock = 9,
                    Duree = new DateTime (2017, 05 ,2)
                }
            );
    }

    
    public DbSet<Book> Books { get; set; } = default!;
    public DbSet<Film> Films { get; set; } = default!;
}
