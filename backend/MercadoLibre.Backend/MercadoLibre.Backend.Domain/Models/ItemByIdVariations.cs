using Newtonsoft.Json;
using System.Collections.Generic;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemByIdVariations : ItemResult
    {
        [JsonProperty(PropertyName = "attribute_combinations")]
        public IList<ItemResultAttribute> AttributeCombinations { get; set; }

        [JsonProperty(PropertyName = "picture_ids")]
        public IList<string> PictureIds { get; set; }
}
}