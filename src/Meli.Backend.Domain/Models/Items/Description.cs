using System;
using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class Description
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
        public DescriptionSnapshot Snapshot { get; set; }
    }
}
