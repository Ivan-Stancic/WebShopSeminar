using WebShopSeminar.Models.Dbo;

namespace WebShopSeminar.Services.Interface
{
    public interface IIdentityService
    {
        Task CreateUserAsync(ApplicationUser user, string password, string role);
        Task CreateRoleAsync(string role);
    }
}