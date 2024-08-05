using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmer_DotNet.Model
{
    public class Farmer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int FarmerId { get; set; }
        public string FName { get; set; }
        public string FEmail { get; set; }
        public string FAddress { get; set; }

        public int? FMoNo { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Vehical> Vehicals { get; set; }
        public ICollection<Market> Markets { get; set; }



    }
}
