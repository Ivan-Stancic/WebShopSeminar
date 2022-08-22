using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShopSeminar.Data;
using WebShopSeminar.Models.Dbo;

namespace WebShopSeminar.Controllers.API
{
    [ApiController]
    [Route("[controller]")]
    public class HomeApiController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeApiController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("Products")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProducts()
        {
            var dbo = await db.Product.ToListAsync();
            return Ok(dbo.Select(x => x).ToList());
        }

        [HttpGet]
        [Route("Product/{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetItem(int id)
        {
            var dbo = await db.Product.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(dbo);
        }
    }
}
