using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses
{
    public class PriceResponse
    {
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "decimals")]
        public int Decimals { get; set; }
    }
}