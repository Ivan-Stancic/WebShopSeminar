using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopSeminar.Models;
using WebShopSeminar.Services.Interface;
using WebShopSeminar.Models.Binding;

namespace WebShopSeminar.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IProductService productService;

        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> ProdcutAdministration()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
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
            return RedirectToAction("ProdcutAdministration");
        }
    }
}