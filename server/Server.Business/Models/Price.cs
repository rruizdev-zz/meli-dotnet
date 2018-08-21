namespace Server.Domain.Models
{
    public class Price
    {
        public string currency { get; set; }

        public int amount { get; set; }

        public int decimals { get; set; }
    }
}