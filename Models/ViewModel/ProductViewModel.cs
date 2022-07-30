using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.ViewModel
{
    public class ProductViewModel : ProductBase
        
    {
        public int Id { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
    }
}
