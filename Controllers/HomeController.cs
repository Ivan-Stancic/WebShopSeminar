using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShopSeminar.Models;
using WebShopSeminar.Models.Binding;
using WebShopSeminar.Services.Interface;

namespace WebShopSeminar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;


        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View(productService.GetProductsAsync().Result);
        }

        public IActionResult Category()
        {
            return View(productService.GetProductCategorysAsync().Result);
        }

        [Authorize]
        public async Task<IActionResult> ItemView(int id)
        {
            var product = await productService.GetProductAsync(id);
            return View(product);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ItemView(ShoppingCartBinding model)
        {
            var product = await productService.AddShoppingCartAsync(model);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}