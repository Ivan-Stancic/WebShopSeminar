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

        public ProductService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        //Dodavanje poizvoda
        public async Task<ProductViewModel> AddProductAsync(ProductBinding model)
        {
            var dbo = mapper.Map<Product>(model);
            var productCategory = await db.ProductCategory.FindAsync(model.ProductCategoryId);
            if(productCategory == null)
            {
                return null;
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
        public async Task<ShoppingChartItemViewModel> AddShoppingChartItemAsync(ShoppingChartItemBinding model)
        {
            var dbo = mapper.Map<ShoppingChartItem>(model);
            db.ShoppingChartItem.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ShoppingChartItemViewModel>(dbo);
        }

        //Dohvat proizvoda iz košare
        public async Task<ShoppingChartItemViewModel> GetShoppingChartItemAsync(int id)
        {
            var dbo = await db.ShoppingChartItem.FindAsync(id);
            return mapper.Map<ShoppingChartItemViewModel>(dbo);
        }

        //Dohvat svih proizvoda iz košare
        public async Task<List<ShoppingChartItemViewModel>> GetShoppingChartItemsAsync()
        {
            var dbo = await db.ShoppingChartItem.ToListAsync();
            return dbo.Select(x => mapper.Map<ShoppingChartItemViewModel>(x)).ToList();
        }
    }
}
