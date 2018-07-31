using Web.Models;

namespace Web.Models.Item
{
    public class ItemDetail : Item
    {
        public int sold_quantity { get; set; }

        public string description { get; set; }
    }
}