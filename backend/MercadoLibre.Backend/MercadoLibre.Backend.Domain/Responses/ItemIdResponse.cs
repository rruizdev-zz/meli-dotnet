using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses
{
    public class ItemIdResponse : ItemResponse
    {
        [JsonProperty(PropertyName = "sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}