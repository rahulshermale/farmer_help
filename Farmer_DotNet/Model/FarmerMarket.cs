namespace Farmer_DotNet.Model
{
    public class FarmerMarket
    {
        public int MarketId { get; set; }
        public int FarmerId { get; set; }

        public Market Markets { get; set; }
        public Farmer Farmers { get; set; }
    }
}
