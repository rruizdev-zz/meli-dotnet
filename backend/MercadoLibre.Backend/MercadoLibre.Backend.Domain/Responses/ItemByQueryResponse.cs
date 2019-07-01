using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Responses
{
    public class ItemByQueryResponse
    {
        [JsonProperty(PropertyName = "author")]
        public AuthorResponse Author => new AuthorResponse();

        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }
        
        [JsonProperty(PropertyName = "items")]
        public IList<ItemResponse> Items { get; set; }
    }
}
