using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.ViewModel
{
    public class ApplicationUserViewModel : ApplicationUserBase
    {
        public string Id { get; set; }
        public string Role { get; set; }
    }
}
