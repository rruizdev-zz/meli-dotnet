using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class KeyValueAttribute
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
