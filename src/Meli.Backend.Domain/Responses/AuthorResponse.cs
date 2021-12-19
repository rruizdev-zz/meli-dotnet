using Newtonsoft.Json;

namespace Meli.Backend.Domain.Responses
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
