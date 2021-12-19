using Newtonsoft.Json;

namespace Meli.Backend.Domain.Responses.Items
{
    public class SearchResponse
    {
        [JsonProperty(PropertyName = "author")]
        public AuthorResponse Author => new AuthorResponse();

        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }
        
        [JsonProperty(PropertyName = "items")]
        public IList<SearchItemResponse> Items { get; set; }
    }
}
