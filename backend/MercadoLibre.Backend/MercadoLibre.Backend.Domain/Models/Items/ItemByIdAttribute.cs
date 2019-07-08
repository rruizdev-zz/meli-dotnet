using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class ItemByIdAttribute : ItemResultAttribute
    {
        [JsonProperty(PropertyName = "value_struct")]
        public new AttributeStruct ValueStruct { get; set; }
    }
}
