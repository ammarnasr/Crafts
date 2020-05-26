using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crafts.website.Models
{
    public class Product
    {
        public String Id { get; set; }
        public String Maker { get; set; }
        [JsonPropertyName("img")]
        public String Image { get; set; }
        public String Url { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public int[] Ratings { get; set; }


        public override string ToString() => JsonSerializer.Serialize(this);

    }
}
