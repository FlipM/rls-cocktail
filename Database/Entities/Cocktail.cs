using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RLS.AwesomeBar.API.Database
{
    public class Cocktail
    {
        [Key]
        public long Id { get; set; }
        
        public string Name { get; set; }

        public string AlternateName { get; set; }

        public string Tags { get; set; }

        public string Category { get; set; }

        public string Instructions { get; set; }

        public string Image { get; set; }

        public string Measures { get; set; }
    }
}
