using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class ShoppingCart : ShoppingCartBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
