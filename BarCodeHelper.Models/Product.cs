using System.ComponentModel.DataAnnotations;

namespace BarCodeHelper.Models
{
    public class Product
    {
        [Key]
        public string SerialNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ProductCategory Category { get; set; }
    }
}
