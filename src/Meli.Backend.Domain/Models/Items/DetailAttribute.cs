using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class DetailAttribute : ResultAttribute
    {
        [JsonProperty(PropertyName = "value_struct")]
        public new AttributeStruct ValueStruct { get; set; }
    }
}
