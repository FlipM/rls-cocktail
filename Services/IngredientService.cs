using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;

namespace RLS.AwesomeBar.API.Services
{
    public class IngredientService
    {
        private readonly BarContext context;

        public IngredientService(BarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsAsync()
        {
            return await context.Ingredients.ToListAsync();
        }

        public async Task<Ingredient> GetIngredientAsync(string id)
        {
            var ingredient = await context.Ingredients.FindAsync(id);

            return ingredient;
        }
    }
}
