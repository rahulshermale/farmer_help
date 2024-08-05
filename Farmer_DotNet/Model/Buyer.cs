using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmer_DotNet.Model
{
    public class Buyer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BuyerId { get; set; }
        public string BName { get; set; }
        public string BEmail { get; set; }
        public string BContact { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
