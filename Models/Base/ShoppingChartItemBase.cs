using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSeminar.Models.Base
{
    public class ShoppingChartItemBase
    {
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        [Display(Name = "Količina")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        [Display(Name = "Cijena")]
        public decimal Price { get; set; }
    }
}
