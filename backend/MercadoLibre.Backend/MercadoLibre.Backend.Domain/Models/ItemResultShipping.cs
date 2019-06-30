using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemResultShipping
    {
        [JsonProperty(PropertyName = "free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
