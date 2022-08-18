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
            CreateMap<ProductUpdateBinding, Product>();
            CreateMap<ProductViewModel, ProductUpdateBinding>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<ProductUpdateBinding, ProductViewModel>();

            CreateMap<ProductCategoryBinding, ProductCategory>();
            CreateMap<ProductCategoryUpdateBinding, ProductCategory>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductCategoryViewModel, ProductCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategoryUpdateBinding>();

            CreateMap<ShoppingCartItemBinding, ShoppingCartItem>();
            CreateMap<ShoppingCartItem, ShoppingCartItemViewModel>();
            CreateMap<ShoppingCart, ShoppingCartViewModel>();

            CreateMap<FileStorage, FileStorageViewModel>();
            CreateMap<FileStorage, FileStorageExpendedViewModel>();
            CreateMap<FileStorageViewModel, FileStorage>().
                ForMember(dst => dst.Id, opts => opts.Ignore());

            CreateMap<ApplicationUser, ApplicationUserViewModel>();
            CreateMap<UserBinding, ApplicationUser>()
                .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email));

        }
    }
}