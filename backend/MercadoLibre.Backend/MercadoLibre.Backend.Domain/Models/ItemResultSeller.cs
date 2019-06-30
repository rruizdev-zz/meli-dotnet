using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemResultSeller
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "power_seller_status")]
        public string PowerSellerStatus { get; set; }

        [JsonProperty(PropertyName = "car_dealer")]
        public bool CarDealer { get; set; }

        [JsonProperty(PropertyName = "real_estate_agency")]
        public bool RealEstateAgency { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
