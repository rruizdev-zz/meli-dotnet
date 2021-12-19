using Newtonsoft.Json;

namespace Meli.Backend.Domain.Responses.Items
{
    public class DetailResponse
    {
        [JsonProperty(PropertyName = "author")]
        public AuthorResponse Author => new AuthorResponse();

        [JsonProperty(PropertyName = "item")]
        public DetailItemResponse Item { get; set; }
    }
}
