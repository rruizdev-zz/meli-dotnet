using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class DescriptionSnapshot
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
