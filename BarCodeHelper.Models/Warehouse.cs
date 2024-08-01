using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarCodeHelper.Models
{
    public class Warehouse
    {
        [Key]
        public string WarehouseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<BarCode> BarCodes { get; set; }

        [Required]
        public ContactInformation Address { get; set; }

    }
}
