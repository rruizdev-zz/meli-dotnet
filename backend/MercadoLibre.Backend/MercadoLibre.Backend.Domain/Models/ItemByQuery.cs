using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemByQuery
    {
        [JsonProperty(PropertyName = "site_id")]
        public string SiteId { get; set; }

        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "paging")]
        public ItemByQueryPaging Paging { get; set; }

        [JsonProperty(PropertyName = "results")]
        public IList<ItemResult> Results { get; set; }

        [JsonProperty(PropertyName = "secondary_results")]
        public IList<ItemResult> SecondaryResults { get; set; }

        [JsonProperty(PropertyName = "related_results")]
        public IList<ItemResult> RelatedResults { get; set; }

        [JsonProperty(PropertyName = "sort")]
        public KeyValueAttribute Sort { get; set; }

        [JsonProperty(PropertyName = "available_sorts")]
        public IList<KeyValueAttribute> AvailableSorts { get; set; }

        [JsonProperty(PropertyName = "filters")]
        public IList<ItemByQueryFilter> Filters { get; set; }

        [JsonProperty(PropertyName = "available_filters")]
        public IList<ItemByQueryFilter> AvailableFilters { get; set; }
    }
}
