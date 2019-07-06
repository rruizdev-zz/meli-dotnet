using Newtonsoft.Json;
using System;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemDescriptionById
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "plain_text")]
        public string PlainText { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "snapshot")]
        public ItemDescriptionByIdSnapshot Snapshot { get; set; }
    }
}
