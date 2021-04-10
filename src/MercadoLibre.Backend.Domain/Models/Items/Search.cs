using System.Collections.Generic;
using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class Search
    {
        [JsonProperty(PropertyName = "site_id")]
        public string SiteId { get; set; }

        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "paging")]
        public SearchPaging Paging { get; set; }

        [JsonProperty(PropertyName = "results")]
        public IList<Result> Results { get; set; }

        [JsonProperty(PropertyName = "secondary_results")]
        public IList<Result> SecondaryResults { get; set; }

        [JsonProperty(PropertyName = "related_results")]
        public IList<Result> RelatedResults { get; set; }

        [JsonProperty(PropertyName = "sort")]
        public KeyValueAttribute Sort { get; set; }

        [JsonProperty(PropertyName = "available_sorts")]
        public IList<KeyValueAttribute> AvailableSorts { get; set; }

        [JsonProperty(PropertyName = "filters")]
        public IList<SearchFilter> Filters { get; set; }

        [JsonProperty(PropertyName = "available_filters")]
        public IList<SearchFilter> AvailableFilters { get; set; }
    }
}
