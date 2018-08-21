namespace Server.Domain.Models.Detail
{
    public class DetailItem : SingleItem
    {
        public int sold_quantity { get; set; }

        public string description { get; set; }
    }
}