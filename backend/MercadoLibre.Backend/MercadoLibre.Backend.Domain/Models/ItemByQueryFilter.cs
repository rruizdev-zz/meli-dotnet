using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemByQueryFilter
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "values")]
        public IList<KeyValueAttribute> Values { get; set; }
    }
}
