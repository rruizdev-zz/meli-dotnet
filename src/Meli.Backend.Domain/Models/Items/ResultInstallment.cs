using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class ResultInstallment
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public decimal? Rate { get; set; }

        [JsonProperty(PropertyName = "currency_id")]
        public string CurrencyId { get; set; }
    }
}
