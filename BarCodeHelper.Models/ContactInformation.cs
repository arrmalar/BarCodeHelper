using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarCodeHelper.Models
{
    public class ContactInformation
    {
        [Key]
        public string ContactId { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City {  get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string StreetNo { get; set; }

        [Required]
        public string PhoneNo { get; set; }
    }
}
