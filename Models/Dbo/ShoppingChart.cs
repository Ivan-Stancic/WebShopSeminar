using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class ShoppingChart : ShoppingChartBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ICollection<ShoppingChartItem> ShoppingChartItems { get; set; }
    }
}
