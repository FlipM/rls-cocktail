using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RLS.AwesomeBar.API.Database
{
    public class SeedItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("alternate_name")]
        public string AlternateName { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("ingredients")]
        public List<string> Ingredients { get; set; }

        [JsonPropertyName("measures")]
        public string Measures { get; set; }
    }
}
