using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses.Items
{
    public class ItemPriceResponse
    {
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "decimals")]
        public decimal Decimals { get; set; }
    }
}