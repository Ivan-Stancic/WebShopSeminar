using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopSeminar.Models;
using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Services.Implementation;
using WebShopSeminar.Services.Interface;

namespace WebShopSeminar.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.signInManager = signInManager;
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserBinding model)
        {
            var result = await userService.CreateUserAsync(model, Roles.BasicUser);
            if (result != null)
            {
                await signInManager.SignInAsync(result, true);
                return RedirectToAction("Index", "Home");
            }


            return View();
        }
    }
}
