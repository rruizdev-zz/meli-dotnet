﻿using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class DetailSeller : DetailGeolocation
    {
        [JsonProperty(PropertyName = "city")]
        public KeyValueAttribute City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public KeyValueAttribute State { get; set; }

        [JsonProperty(PropertyName = "country")]
        public KeyValueAttribute Country { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "search_location")]
        public SellerLocation SearchLocation { get; set; }
    }
}