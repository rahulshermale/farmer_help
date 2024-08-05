using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmer_DotNet.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int? ProductId { get; set; }
        public string PName { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? AvgPrice { get; set; }

        public ICollection<Market> Markets { get; set; }
        public ICollection<Farmer> Farmers { get; set; }
    }
}
