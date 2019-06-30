using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemResultAddress
    {
        [JsonProperty(PropertyName = "state_id")]
        public string StateId { get; set; }

        [JsonProperty(PropertyName = "state_name")]
        public string StateName { get; set; }

        [JsonProperty(PropertyName = "city_id")]
        public string CityId { get; set; }

        [JsonProperty(PropertyName = "city_name")]
        public string CityName { get; set; }
    }
}
