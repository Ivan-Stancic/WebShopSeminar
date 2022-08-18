using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShopSeminar.Data;
using WebShopSeminar.Models.Binding;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;
using WebShopSeminar.Services.Interface;

namespace WebShopSeminar.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;
        private readonly ApplicationDbContext db;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.db = db;
        }

        public async Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role)
        {
            var find = await userManager.FindByEmailAsync(model.Email);
            if (find != null)
            {
                return null;
            }
            var user = mapper.Map<ApplicationUser>(model);
            var createdUser = await userManager.CreateAsync(user, model.Password);
            if (createdUser.Succeeded)
            {
                var userAddedToRole = await userManager.AddToRoleAsync(user, role);
                if (!userAddedToRole.Succeeded)
                {
                    throw new Exception("Korisnik nije dodan u rolu!");
                }
            }
            return user;
        }

        public async Task<List<ApplicationUserViewModel>> GetUsers()
        {
            var dboUsers = await db.Users
                .Include(x => x.Address)
                .ToListAsync();
            var response = dboUsers.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();
            response.ForEach(x => x.Role = GetUserRole(x.Id).Result);
            return response;

        }

        public async Task<string> GetUserRole(string id)
        {
            var dboUser = await db.Users.FindAsync(id);
            if (dboUser == null)
            {
                return String.Empty;
            }
            var roles = await userManager.GetRolesAsync(dboUser);
            return roles.First();

        }
    }
}
