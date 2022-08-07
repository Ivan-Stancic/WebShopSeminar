using System.ComponentModel.DataAnnotations;
using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Binding
{
    public class ProductBinding : ProductBase
    {
        public int ProductCategoryId { get; set; }
        [Display(Name = "Slika proizvoda")]
        public IFormFile ProductImg { get; set; }
    }
}
