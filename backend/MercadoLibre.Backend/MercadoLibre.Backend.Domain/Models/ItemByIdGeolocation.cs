using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemByIdGeolocation
    {
        [JsonProperty(PropertyName = "Latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty(PropertyName = "Longitude")]
        public decimal Longitude { get; set; }
    }
}