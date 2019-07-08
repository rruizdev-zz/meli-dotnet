using System.Collections.Generic;
using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models.Items
{
    public class ItemByIdVariations : ItemResult
    {
        [JsonProperty(PropertyName = "attribute_combinations")]
        public IList<ItemResultAttribute> AttributeCombinations { get; set; }

        [JsonProperty(PropertyName = "picture_ids")]
        public IList<string> PictureIds { get; set; }
}
}