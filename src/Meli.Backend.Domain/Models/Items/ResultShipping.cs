using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class ResultShipping
    {
        [JsonProperty(PropertyName = "free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
