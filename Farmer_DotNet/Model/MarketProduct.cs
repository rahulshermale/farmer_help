namespace Farmer_DotNet.Model
{
    public class MarketProduct
    {

        public int MarketId { get; set; }
        public int? ProductId { get; set; }

        public Market Markets { get; set; }
        public Product Products { get; set; }


    }
}
