using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;

namespace RLS.AwesomeBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IngredientService service;

        public IngredientsController(IngredientService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Ingredient>> GetIngredients()
        {
            return await service.GetIngredientsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(string id)
        {
            var ingredient = await service.GetIngredientAsync(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return ingredient;
        }
    }
}
