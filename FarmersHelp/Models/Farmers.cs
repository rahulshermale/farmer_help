namespace FarmersHelp.Models
{
    public class Farmers
    {
        public int FID { get; set; }
        public string  FarmerName{ get; set; }

        public string City { get; set; }
        public int Mobile { set; get; }


        public Markets markets { get; set; }
    }
}
