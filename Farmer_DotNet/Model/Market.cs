using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmer_DotNet.Model
{
    public class Market
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarketId { get; set; }
        public string MName { get; set; }
        public string MEmail { get; set; }
        public int? MContact { get; set; }
        public string MCity { get; set; }
        public string MAddress { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Farmer> Markets { get; set; }
        public ICollection<Buyer> Buyers { get; set; }
        public ICollection<Vehical> Vehicals { get; set; }

    }
}
