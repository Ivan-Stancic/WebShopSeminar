using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Binding
{
    public class ProductCategoryBinding : ProductCategoryBase
    {
    }

    public class ProductCategoryUpdateBinding : ProductCategoryBase
    {
        public int Id { get; set; }
    }
}
