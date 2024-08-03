namespace FarmersHelp.Models
{
    public class Markets
    {



        public int ID { get; set; }
        public string MarketNAme { get; set; }
        public string City { get; set; }

        public IEnumerable<Farmers> farmers { get; set; }
    }
}
