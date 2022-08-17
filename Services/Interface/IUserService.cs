using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;

namespace WebShopSeminar.Services.Interface
{
    public interface IUserService
    {
        Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role);
    }
}