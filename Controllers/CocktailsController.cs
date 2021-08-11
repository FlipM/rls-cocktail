using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Mvc;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;

namespace RLS.AwesomeBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailsController : ControllerBase
    {
        private readonly CocktailService service;
        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        public CocktailsController(CocktailService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<CocktailWithIngredients>> GetCocktails()
        {
            return await service.GetCocktailsAsync();
        }

        [HttpGet("name")]
        public async Task<List<CocktailWithIngredients>> GetCocktails(string name)
        {

            List<CocktailWithIngredients> cocktails;

            //Caching queries
            if (!_cache.TryGetValue(name, out cocktails))
            {
                cocktails = await service.GetCocktailsAsync(name);
                _cache.Set(name, cocktails);
            }

            if (cocktails.Count == 0)
                {
                    Console.WriteLine($"No cocktails were found with the name '{name}'");
                    return null;
                }

            return cocktails;
        }

        [HttpGet("random")]
        public async Task<CocktailWithIngredients> GetRandomCocktail()
        {
            return await service.GetRandomCocktailAsync();
        }
    }
}
