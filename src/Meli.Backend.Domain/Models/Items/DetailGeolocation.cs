using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class DetailGeolocation
    {
        [JsonProperty(PropertyName = "Latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty(PropertyName = "Longitude")]
        public decimal Longitude { get; set; }
    }
}