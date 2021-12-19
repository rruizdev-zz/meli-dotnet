using System.Collections.Generic;
using Newtonsoft.Json;

namespace Meli.Backend.Domain.Models.Items
{
    public class DetailVariation : Result
    {
        [JsonProperty(PropertyName = "attribute_combinations")]
        public IList<ResultAttribute> AttributeCombinations { get; set; }

        [JsonProperty(PropertyName = "picture_ids")]
        public IList<string> PictureIds { get; set; }
}
}