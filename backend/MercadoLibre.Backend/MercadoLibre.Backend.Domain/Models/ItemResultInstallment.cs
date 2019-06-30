using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemResultInstallment
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
