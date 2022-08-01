using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class ShoppingChartItem : ShoppingChartItemBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public Product Product { get; set; }
    }
}
