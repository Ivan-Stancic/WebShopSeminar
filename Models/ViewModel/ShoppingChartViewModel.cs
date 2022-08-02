using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.ViewModel
{
    public class ShoppingCartViewModel : ShoppingCartBase
    {
        public int Id { get; set; }
        public List<ShoppingCartItemViewModel> ShoppingCartItems { get; set; }
    }
}
