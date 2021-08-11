using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;

namespace RLS.AwesomeBar.API.Services
{
    public class CategoryService
    {
        private readonly BarContext context;

        public CategoryService(BarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(string id)
        {
            var category = await context.Categories.FindAsync(id);

            return category;
        }
    }
}
