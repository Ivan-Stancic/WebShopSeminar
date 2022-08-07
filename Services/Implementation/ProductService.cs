using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebShopSeminar.Data;
using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;
using WebShopSeminar.Services.Interface;

namespace WebShopSeminar.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly IFileStorageService fileStorageService;

        public ProductService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
            this.fileStorageService = fileStorageService;
        }

        //Dodavanje nove košare
        public async Task<ShoppingCartViewModel> AddShoppingCartAsync(ShoppingCartBinding model)
        {
            var product = await db.Product.FindAsync(model.ProductId);
            var user = await db.Users.FirstOrDefaultAsync(x => x.Id == model.UserId);
            if(product == null || user == null)
            {
                return null;
            }
            var shoppingCartItem = new ShoppingCartItem
            {
                Price = model.Price,
                Product = product,
                Quantity = model.Quantity
            };
            var dbo = new ShoppingCart
            {
                ShoppingCartItems = new List<ShoppingCartItem> { shoppingCartItem },
                ApplicationUser = user
            };

            db.ShoppingCart.Add(dbo);
            await db.SaveChangesAsync();
            return  mapper.Map<ShoppingCartViewModel>(dbo);
        }

        //Dodavanje poizvoda
        public async Task<ProductViewModel> AddProductAsync(ProductBinding model)
        {
            var dbo = mapper.Map<Product>(model);
            var productCategory = await db.ProductCategory.FindAsync(model.ProductCategoryId);
            if(productCategory == null)
            {
                var fileResponse = await fileStorageService.AddFileToStorage(model.ProductImg);
                if (fileResponse != null)
                {
                    dbo.ProductImgUrl = fileResponse.DownloadUrl;
                }
            }
            dbo.ProductCategory = productCategory;
            db.Product.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(dbo);
        }

        //Dohvati proizvod putem Id-a
        public async Task<ProductViewModel> GetProductAsync(int id)
        {
            var dbo = await db.Product
                .Include(x=>x.ProductCategory)
                .FirstOrDefaultAsync(x=>x.Id == id);
            return mapper.Map<ProductViewModel>(dbo);
        }

        //Edit produkta
        public async Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model)
        {
            var category = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.ProductCategoryId);
            var dbo = await db.Product.FindAsync(model.Id);
            mapper.Map(model, dbo);
            dbo.ProductCategory = category;
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(dbo);
        }

        public async Task DeleteProductAsync(Product model)
        {
            var product = await db.Product.FirstOrDefaultAsync(x => x.Id == model.Id);
            db.Product.Remove(product);
            await db.SaveChangesAsync();
        }

        //Dohvat svih proizvoda
        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var dbo = await db.Product.ToListAsync();
            return dbo.Select(x => mapper.Map<ProductViewModel>(x)).ToList();
        }

        //Dodavanje kategorij proizvoda
        public async Task<ProductCategoryViewModel> AddProductCategoryAsync(ProductCategoryBinding model)
        {
            var dbo = mapper.Map<ProductCategory>(model);
            db.ProductCategory.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(dbo);
        }

        //Dohvat kategorije
        public async Task<ProductCategoryViewModel> GetProductCategoryAsync(int id)
        {
            var dbo = await db.ProductCategory.FindAsync(id);
            return mapper.Map<ProductCategoryViewModel>(dbo);
        }

        //Dohvat svih katgorija
        public async Task<List<ProductCategoryViewModel>> GetProductCategorysAsync()
        {
            var dbo = await db.ProductCategory.ToListAsync();
            return dbo.Select(x => mapper.Map<ProductCategoryViewModel>(x)).ToList();
        }

        //Edit kategorije
        public async Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model)
        {
            var dbo = await db.ProductCategory.FindAsync(model.Id);
            mapper.Map(model, dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(dbo);
        }

        //Dodavanje predmeta u košaricu
        public async Task<ShoppingCartItemViewModel> AddShoppingCartItemAsync(ShoppingCartItemBinding model)
        {
            var dbo = mapper.Map<ShoppingCartItem>(model);
            db.ShoppingCartItem.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ShoppingCartItemViewModel>(dbo);
        }

        //Dohvat proizvoda iz košare
        public async Task<ShoppingCartItemViewModel> GetShoppingCartItemAsync(int id)
        {
            var dbo = await db.ShoppingCartItem.FindAsync(id);
            return mapper.Map<ShoppingCartItemViewModel>(dbo);
        }

        //Dohvat svih proizvoda iz košare
        public async Task<List<ShoppingCartItemViewModel>> GetShoppingCartItemsAsync()
        {
            var dbo = await db.ShoppingCartItem.ToListAsync();
            return dbo.Select(x => mapper.Map<ShoppingCartItemViewModel>(x)).ToList();
        }
    }
}
