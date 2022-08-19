using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class Product : ProductBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("Product")]
        public int ProductCategoryId { get; set; }
    }
}
