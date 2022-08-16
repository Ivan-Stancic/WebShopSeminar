using Microsoft.AspNetCore.Identity;

namespace WebShopSeminar.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<ShoppingCart> ShoppingCart { get; set; }
        public string Password { get; set; }

    }
}
