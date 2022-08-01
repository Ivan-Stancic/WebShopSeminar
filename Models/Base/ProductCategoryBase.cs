using System.ComponentModel.DataAnnotations;

namespace WebShopSeminar.Models.Base
{
    public class ProductCategoryBase
    {
        [Required(ErrorMessage ="Obavezan unos!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
