namespace WebShopSeminar.Models.Binding
{
    public class ShoppingCartBinding
    {
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
    }
}
