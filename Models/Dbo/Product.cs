using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSeminar.Models.Dbo
{
    public class Product : EntityBase
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Column(TypeName ="decimal(9, 2)")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Price { get; set; }
    }
}
