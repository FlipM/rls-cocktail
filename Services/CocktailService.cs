using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;

namespace RLS.AwesomeBar.API.Services
{
    public class CocktailService
    {
        private readonly BarContext context;
        private static Random rnd = new Random();

        public CocktailService(BarContext context)
        {
            this.context = context;
        }

        public async Task<List<CocktailWithIngredients>> GetCocktailsAsync()
        {
            return await FillCocktailsWithIngredients(context.Cocktails.ToList());
        }

        public async Task<List<CocktailWithIngredients>> GetCocktailsAsync(string id)
        {
            if(id == "")
                return await GetCocktailsAsync();

            var cocktails = await context.Cocktails.Where(c => c.Name.Contains(id)).ToListAsync();

            return await FillCocktailsWithIngredients(cocktails);
        }

        public async Task<List<CocktailWithIngredients>> FillCocktailsWithIngredients(List<Cocktail> cocktails)
        {
            var cocktailWIngredientList = new List<CocktailWithIngredients>();
            foreach(var c in cocktails)
            {
                var ingredients = await context.CocktailIngredients.Where(ci => ci.CocktailId == c.Id).Select(ci => ci.IngredientName).ToListAsync();
                cocktailWIngredientList.Add(new CocktailWithIngredients
                {
                    Name = c.Name,
                    AlternateName = c.AlternateName,
                    Tags = c.Tags,
                    Category = c.Category,
                    Instructions = c.Instructions,
                    Image = c.Image,
                    Ingredients = ingredients,
                    Measures = c.Measures,
                });
            }
            return cocktailWIngredientList;
        }

        public async Task<CocktailWithIngredients> GetRandomCocktailAsync()
        {
            //Maintain rng outside to avoid repeating indexes
            var cocktails = await context.Cocktails.ToListAsync();
            var randomCocktail =  cocktails[rnd.Next(cocktails.Count)];

            var ingredients = await context.CocktailIngredients.Where(ci => ci.CocktailId == randomCocktail.Id).Select(ci => ci.IngredientName).ToListAsync();
            return new CocktailWithIngredients
                {
                    Name = randomCocktail.Name,
                    AlternateName = randomCocktail.AlternateName,
                    Tags = randomCocktail.Tags,
                    Category = randomCocktail.Category,
                    Instructions = randomCocktail.Instructions,
                    Image = randomCocktail.Image,
                    Ingredients = ingredients,
                    Measures = randomCocktail.Measures,
                };
        }
    }
}
