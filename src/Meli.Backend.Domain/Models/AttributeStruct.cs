using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models
{
    public class AttributeStruct
    {
        [JsonProperty(PropertyName = "number")]
        public decimal Number { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }
}