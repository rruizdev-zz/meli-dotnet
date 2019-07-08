using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class SellerLocation
    {
        [JsonProperty(PropertyName = "neighborhood")]
        public KeyValueAttribute Neighborhood { get; set; }

        [JsonProperty(PropertyName = "city")]
        public KeyValueAttribute City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public KeyValueAttribute State { get; set; }
    }
}