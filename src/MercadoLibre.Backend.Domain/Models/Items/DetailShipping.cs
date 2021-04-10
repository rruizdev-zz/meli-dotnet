using System.Collections.Generic;
using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class DetailShipping
    {
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        [JsonProperty(PropertyName = "free_methods")]
        public IList<ShippingFreeMethod> FreeMethods { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        [JsonProperty(PropertyName = "local_pick_up")]
        public bool LocalPickUp { get; set; }

        [JsonProperty(PropertyName = "free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty(PropertyName = "logistic_type")]
        public string LogisticType { get; set; }

        [JsonProperty(PropertyName = "store_pick_up")]
        public bool StorePickUp { get; set; }
    }
}
