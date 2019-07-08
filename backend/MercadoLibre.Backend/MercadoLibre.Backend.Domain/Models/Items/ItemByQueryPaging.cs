using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class ItemByQueryPaging
    {
        [JsonProperty(PropertyName = "total")]
        public int? TotalResults { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        [JsonProperty(PropertyName = "limit")]
        public int? LimitPerPage { get; set; }

        [JsonProperty(PropertyName = "primary_results")]
        public int? PrimaryResults { get; set; }
    }
}
