using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses.Items
{
    public class DetailItemResponse : SearchItemResponse
    {
        [JsonProperty(PropertyName = "sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}