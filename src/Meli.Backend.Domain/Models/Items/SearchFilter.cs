using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class SearchFilter
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
