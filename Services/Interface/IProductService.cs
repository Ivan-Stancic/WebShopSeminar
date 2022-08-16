using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> AddProductAsync(ProductBinding model);
        Task<ProductViewModel> GetProductAsync(int id);
        Task<List<ProductViewModel>> GetProductsAsync();
        Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model);
        Task DeleteProductAsync(Product model);
        Task<ProductCategoryViewModel> AddProductCategoryAsync(ProductCategoryBinding model);
        Task<ProductCategoryViewModel> GetProductCategoryAsync(int id);
        Task<List<ProductCategoryViewModel>> GetProductCategorysAsync();
        Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model);
        Task DeleteProductCategoryAsync(ProductCategory model);
        Task<ShoppingCartViewModel> AddShoppingCartAsync(ShoppingCartBinding model);
    }
}