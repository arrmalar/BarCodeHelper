using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarCodeHelper.Models
{
    public class BarCode
    {
        [Key, Column(Order = 0)]
        public string BarCodeNumber { get; set; }

        [Key, Column(Order = 1)]
        public string ProductSerialNumber { get; set; }

        [ForeignKey("ProductSerialNumber")]
        [Required]
        public Product Product { get; set; }

        [Required]
        public DateTime Created {  get; set; }

    }
}
