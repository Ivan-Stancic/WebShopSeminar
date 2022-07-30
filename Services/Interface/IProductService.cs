using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> AddProductAsync(ProductBinding model);
        Task<ProductViewModel> GetProductAsync(int id);
        Task<List<ProductViewModel>> GetProductsAsync();
    }
}