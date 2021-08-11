using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RLS.AwesomeBar.API.Database
{
    public class CocktailWithIngredients
    {
        
        public string Name { get; set; }

        public string AlternateName { get; set; }

        public string Tags { get; set; }

        public string Category { get; set; }

        public string Instructions { get; set; }

        public string Image { get; set; }

        public List<string> Ingredients { get; set; }

        public string Measures { get; set; }
    }
}
