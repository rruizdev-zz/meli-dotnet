using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class Result
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "site_id")]
        public string SiteId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "seller")]
        public ResultSeller Seller { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        [JsonProperty(PropertyName = "currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty(PropertyName = "available_quantity")]
        public int? AvailableQuantity { get; set; }

        [JsonProperty(PropertyName = "sold_quantity")]
        public int? SoldQuantity { get; set; }

        [JsonProperty(PropertyName = "buying_mode")]
        public string BuyingMode { get; set; }

        [JsonProperty(PropertyName = "listing_type_id")]
        public string ListingTypeId { get; set; }

        [JsonProperty(PropertyName = "stop_time")]
        public DateTime? StopTime { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        [JsonProperty(PropertyName = "permalink")]
        public string Permalink { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty(PropertyName = "accepts_mercadopago")]
        public bool AcceptsMercadoPago { get; set; }

        [JsonProperty(PropertyName = "installments")]
        public ResultInstallment Installments { get; set; }

        [JsonProperty(PropertyName = "address")]
        public ResultAddress Address { get; set; }

        [JsonProperty(PropertyName = "shipping")]
        public ResultShipping Shipping { get; set; }

        [JsonProperty(PropertyName = "seller_address")]
        public ResultSellerAddress SellerAddress { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public IList<ResultAttribute> Attributes { get; set; }

        [JsonProperty(PropertyName = "original_price")]
        public decimal? OriginalPrice { get; set; }

        [JsonProperty(PropertyName = "category_id")]
        public string CategoryId { get; set; }

        [JsonProperty(PropertyName = "official_store_id")]
        public string OfficialStoreId { get; set; }

        [JsonProperty(PropertyName = "catalog_product_id")]
        public string CatalogProductId { get; set; }
        
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
