using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Data;

public class ApbdContext : DbContext
{
    public ApbdContext()
    {
    }

    public ApbdContext(DbContextOptions<ApbdContext> options)
        : base(options)
    {
    }
    public DbSet<backpacks> Backpacks { get; set; } 
    public DbSet<character_titles> CharacterTitles { get; set; }
    public DbSet<characters> Characters { get; set; }
    public DbSet<items> Items { get; set; }
    public DbSet<titles> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<titles>().HasData(new List<titles>
        {
            new titles
            {
                Id = 1,
                Name = "Jan",
            },
            new titles
            {
                Id = 2,
                Name = "Anna",
            }
        });
        
         modelBuilder.Entity<items>().HasData(new List<items>
            {
                new items {
                    Id = 1,
                    Name = "Adam",
                    Weight = 13
                },
                new items {
                    Id = 2,
                    Name = "Aleksandra",
                    Weight = 12
                }
            });

            modelBuilder.Entity<characters>().HasData(new List<characters>
            {
                new characters
                {
                    Id = 1,
                    FirstName = "Katarzyna",
                    LastName = "Sierdzińska",
                    CurrentWei = 40,
                    MaxWeight = 90
                },
                new characters
                {
                    Id = 2,
                    FirstName = "Andrzej",
                    LastName = "Andrzejewski",
                    CurrentWei = 50,
                    MaxWeight = 100
                },
             
            });

            modelBuilder.Entity<character_titles>().HasData(new List<character_titles>
            {
                new character_titles
                {
                    CharacterId = 1,
                    TitleId = 1,
                    AcquiredAt = DateTime.Parse("2024-05-29"),
                },
                new character_titles
                {
                    CharacterId = 2,
                    TitleId = 2,
                    AcquiredAt = DateTime.Parse("2025-06-21"),
                },
            });

            modelBuilder.Entity<backpacks>().HasData(new List<backpacks>
            {
                new backpacks
                {
                    CharacterId = 2,
                    ItemId = 2,
                    Amount = 3,
                },
                new backpacks
                {
                    CharacterId = 1,
                    ItemId = 1,
                    Amount = 8,
                },
            });
    }
}