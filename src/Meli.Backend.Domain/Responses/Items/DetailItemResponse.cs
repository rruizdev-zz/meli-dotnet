using Newtonsoft.Json;

namespace Meli.Backend.Domain.Responses.Items
{
    public class DetailItemResponse : SearchItemResponse
    {
        [JsonProperty(PropertyName = "sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}