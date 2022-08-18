using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Services.Interface
{
    public interface IUserService
    {
        Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role);
        Task<List<ApplicationUserViewModel>> GetUsers();
        Task<string> GetUserRole(string id);
        Task<List<UserRolesViewModel>> GetUserRoles();
        Task<ApplicationUserViewModel?> CreateUserAsync(UserAdminBinding model);
        Task DeleteUserAsync(string id);
    }
}