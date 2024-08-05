using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmer_DotNet.Model
{
    public class Vehical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int VehicalId { get; set; }
        public string VName { get; set; }
        public string VType { get; set; }
       

    }
}
