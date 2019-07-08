using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses
{
    public class ItemByIdResponse
    {
        [JsonProperty(PropertyName = "author")]
        public AuthorResponse Author => new AuthorResponse();

        [JsonProperty(PropertyName = "item")]
        public ItemIdResponse Item { get; set; }
    }
}
