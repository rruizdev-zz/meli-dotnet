using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class ShippingFreeMethod
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "rule")]
        public FreeMethodRule Rule { get; set; }
    }
}
