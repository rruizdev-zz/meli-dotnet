using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class ResultSellerAddress
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "address_line")]
        public string AddressLine { get; set; }

        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "country")]
        public KeyValueAttribute Country { get; set; }

        [JsonProperty(PropertyName = "state")]
        public KeyValueAttribute State { get; set; }

        [JsonProperty(PropertyName = "city")]
        public KeyValueAttribute City { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
    }
}
