using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSeminar.Models.Base
{
    public class ProductBase
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        [Display(Name = "Naziv")]
        public string Title { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        [Display(Name = "Količina")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        [Display(Name = "Cijena")]
        public decimal Price { get; set; }
        public string? ProductImgUrl { get; set; }

    }
}
