using AutoMapper;
using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductBinding, Product>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductCategoryBinding, ProductCategory>();
            CreateMap<ProductCategoryUpdateBinding, ProductCategory>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ShoppingChartItemBinding, ShoppingChartItem>();
            CreateMap<ShoppingChartItem, ShoppingChartItemViewModel>();
        }
    }
}
