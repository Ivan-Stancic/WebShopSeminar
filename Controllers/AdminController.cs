using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopSeminar.Models;
using WebShopSeminar.Services.Interface;
using WebShopSeminar.Models.Binding;
using AutoMapper;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public AdminController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> ProductAdministration()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProduct")]
        public async Task<IActionResult> DeleteProductConfirmed(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);
            await productService.DeleteProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<ProductUpdateBinding>(product);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateBinding model)
        {
            var product = await productService.UpdateProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> AddProduct(ProductBinding model)
        {
            var products = await productService.AddProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> AddProductCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProductCategory(ProductCategoryBinding model)
        {
            var products = await productService.AddProductCategoryAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        public async Task<IActionResult> UpdateProductCategory(int id)
        {
            var productCategory = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategoryUpdateBinding>(productCategory);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductCategory(ProductCategoryUpdateBinding model)
        {
            var productCategory = await productService.UpdateProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryAdministration");
        }

        public async Task<IActionResult> DeleteProductCategory(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(product);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProductCategory")]
        public async Task<IActionResult> DeleteProductCategoryConfirmed(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(product);

            await productService.DeleteProductCategoryAsync(model);

            return RedirectToAction("ProductCategoryAdministration");
        }

        public async Task<IActionResult> ProductCategoryAdministration()
        {
            var products = await productService.GetProductCategorysAsync();
            return View(products);
        }
    }
}