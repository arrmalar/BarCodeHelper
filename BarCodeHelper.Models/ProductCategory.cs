using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BarCodeHelper.Models
{
    public enum ProductCategory
    {
        [Description("Swimwear")]
        Swimwear = 1,
        [Description("Pants")]
        Pants = 2,
        [Description("Underwear")]
        Underwear = 3,
        [Description("TShirt")]
        TShirt = 4
    }
}
