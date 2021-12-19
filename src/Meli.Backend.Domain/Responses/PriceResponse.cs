using Newtonsoft.Json;

namespace Meli.Backend.Domain.Responses
{
    public class PriceResponse
    {
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "decimals")]
        public decimal Decimals { get; set; }
    }
}