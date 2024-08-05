namespace Farmer_DotNet.Model
{
    public class FarmerProduct
    {
        public int? ProductId { get; set; }
        public int FarmerId { get; set; }

        public Farmer Farmers { get; set; }
        public Product Products { get; set; }

    }
}
