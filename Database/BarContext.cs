using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace RLS.AwesomeBar.API.Database
{
    public class BarContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<CocktailIngredient> CocktailIngredients { get; set; }

        public BarContext(DbContextOptions<BarContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var jsonString = File.ReadAllText("./Database/Seed/cocktails.json");
            
            var seedData = JsonSerializer.Deserialize<List<SeedItem>>(jsonString);

            foreach (var category in seedData.Select(s => s.Category).Distinct())
            {
                modelBuilder.Entity<Category>().HasData(new Category
                {
                    Name = category,
                    CreatedAt = DateTime.UtcNow,
                });
            }

            foreach (var ingredient in seedData.SelectMany(s => s.Ingredients).Distinct())
            {
                modelBuilder.Entity<Ingredient>().HasData(new Ingredient
                {
                    Name = ingredient,
                    CreatedAt = DateTime.UtcNow,
                });
            }

            //This should be safe even if the cocktailId go over relationId initial value, but 100000 seems to be a good upper bound
            long cocktailId = 1;
            long relationId = 100000;
            foreach (var cocktail in seedData.Distinct())
            {
                modelBuilder.Entity<Cocktail>().HasData(new Cocktail
                {
                    Name = cocktail.Name,
                    AlternateName = cocktail.AlternateName,
                    Tags = cocktail.Tags,
                    Category = cocktail.Category,
                    Instructions = cocktail.Instructions,
                    Image = cocktail.Image,
                    Measures = cocktail.Measures,
                    Id = ++cocktailId
                });

                foreach (var i in cocktail.Ingredients)
                {
                    modelBuilder.Entity<CocktailIngredient>().HasData(new CocktailIngredient
                    {
                      RelationId = ++relationId,
                      CocktailId = cocktailId,
                      IngredientName = i
                    });
                }
            }
        }
    }
}
