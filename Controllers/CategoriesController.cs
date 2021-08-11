using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;

namespace RLS.AwesomeBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService service;

        public CategoriesController(CategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await service.GetCategoriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(string id)
        {
            var category = await service.GetCategoryAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}
