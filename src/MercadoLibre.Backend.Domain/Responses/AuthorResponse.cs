using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Responses
{
    public class AuthorResponse
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }

        public AuthorResponse()
        {
            Name = "Roberto";

            LastName = "Ruiz";
        }
    }
}
