using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses.Items
{
    public class AuthorResponse
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "aulastnamethor")]
        public string LastName { get; set; }

        public AuthorResponse()
        {
            Name = "Roberto";

            LastName = "Ruiz";
        }
    }
}
