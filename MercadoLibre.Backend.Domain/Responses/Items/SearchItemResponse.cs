using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses.Items
{
    public class SearchItemResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "price")]
        public PriceResponse Price { get; set; }

        [JsonProperty(PropertyName = "picture")]
        public string Picture { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        [JsonProperty(PropertyName = "free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
    }
}
