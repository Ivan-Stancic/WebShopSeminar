using Microsoft.AspNetCore.Identity;
using WebShopSeminar.Models;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Services.Interface;

namespace WebShopSeminar.Services.Implementation
{
    public class IdentityService : IIdentityService
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;

        //Prilikom pokretanja aplikacije imamo spremne role u sustavu, u konstruktoru nema async dodaje se wait.
        public IdentityService(IServiceScopeFactory scopeFactory)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                this.userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                this.roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                CreateRoleAsync(Roles.Admin).Wait();
                CreateRoleAsync(Roles.Editor).Wait();
                CreateRoleAsync(Roles.BasicUser).Wait();

                //Kreiranje Admina
                CreateUserAsync(new ApplicationUser
                {
                    Firstname = "Ivan",
                    Lastname = "Stančić",
                    UserName = "ivan",
                    Email = "ivan@ivan.hr",
                    DOB = DateTime.Now.AddYears(-35),
                    Address = new List<Address>
                    {
                        new Address
                        {
                            City = "Zagreb",
                            Street = "Maximirska"
                        }
                    }
                }, "Pass1234", Roles.Admin).Wait();
            }
        }
        //Metoda kreiranja rola
        public async Task CreateRoleAsync(string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = role
                });
            }
        }

        //Kreiranje usera
        public async Task CreateUserAsync(ApplicationUser user, string password, string role)
        {
            //Provjera ima li korisnika sa istim mailom u bazi
            var find = await userManager.FindByEmailAsync(user.Email);
            if (find != null)
            {
                return;
            }
            //Potvrda maila za account
            user.EmailConfirmed = true;
            var createdUser = await userManager.CreateAsync(user, password);
            //Provjera dali je korisnik uspiješno dodan
            if (createdUser.Succeeded)
            {
                //Dodavanje u rolu
                var userAddeaToRole = await userManager.AddToRoleAsync(user, role);

                //Ako korisnik nema rolu baca grešku
                if (!userAddeaToRole.Succeeded)
                {
                    throw new Exception("Korisnik nema rolu!");
                }
            }
        }
    }
}
