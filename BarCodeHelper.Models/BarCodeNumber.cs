using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarCodeHelper.Models
{
    public class BarCodeNumber
    {
        [Required]
        public string Number { get; set; }

    }
}
