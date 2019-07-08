using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemById : ItemResult
    {
        [JsonProperty(PropertyName = "subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty(PropertyName = "seller_id")]
        public long SellerId { get; set; }

        [JsonProperty(PropertyName = "base_price")]
        public decimal BasePrice { get; set; }

        [JsonProperty(PropertyName = "initial_quantity")]
        public int SaleTerms { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "secure_thumbnail")]
        public string SecureThumbnail { get; set; }

        [JsonProperty(PropertyName = "pictures")]
        public IList<ItemByIdPicture> Pictures { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public new IList<ItemByIdAttribute> Attributes { get; set; }

        [JsonProperty(PropertyName = "shipping")]
        public new ItemByIdShipping Shipping { get; set; }

        [JsonProperty(PropertyName = "seller_address")]
        public new ItemByIdSeller SellerAddress { get; set; }

        [JsonProperty(PropertyName = "geolocation")]
        public ItemByIdGeolocation Geolocation { get; set; }

        [JsonProperty(PropertyName = "listing_source")]
        public string ListingSource { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "warranty")]
        public string Warranty { get; set; }

        [JsonProperty(PropertyName = "domain_id")]
        public string DomainId { get; set; }

        [JsonProperty(PropertyName = "automatic_relist")]
        public bool AutomaticRelist { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty(PropertyName = "health")]
        public double Health { get; set; }

        [JsonProperty(PropertyName = "variations")]
        public IList<ItemByIdVariations> Variations { get; set; }
    }
}
