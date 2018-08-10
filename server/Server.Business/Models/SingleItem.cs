namespace Server.Business.Models
{
    public class SingleItem
    {
        public string id { get; set; }

        public string title { get; set; }

        public Price price { get; set; }

        public string picture { get; set; }

        public string condition { get; set; }

        public bool free_shipping { get; set; }
    }
}