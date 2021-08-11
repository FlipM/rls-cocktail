using System;
using System.ComponentModel.DataAnnotations;

namespace RLS.AwesomeBar.API.Database
{
    public class CocktailIngredient
    {
        [Key]
        public long RelationId { get; set; }

        public long CocktailId { get; set; }

        public string IngredientName { get; set; }
    }
}

