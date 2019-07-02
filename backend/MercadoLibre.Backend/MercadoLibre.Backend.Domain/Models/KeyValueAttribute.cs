using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class KeyValueAttribute
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "path_from_root")]
        public IList<KeyValueAttribute> PathFromRoot { get; set; }
    }
}
