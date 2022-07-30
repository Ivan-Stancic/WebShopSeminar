using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopSeminar.Models.Dbo;
using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<WebShopSeminar.Models.ViewModel.ProductViewModel>? ProductViewModel { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }


    }
}