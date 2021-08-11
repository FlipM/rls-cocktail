using System;
using System.ComponentModel.DataAnnotations;

namespace RLS.AwesomeBar.API.Database
{
    public class Ingredient
    {
        [Key]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
