using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class ItemByIdPicture
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "secure_url")]
        public string SecureUrl { get; set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        [JsonProperty(PropertyName = "max_size")]
        public string MaxSize { get; set; }

        [JsonProperty(PropertyName = "quality")]
        public string Quality { get; set; }
    }
}