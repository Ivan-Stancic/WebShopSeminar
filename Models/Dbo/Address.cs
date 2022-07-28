using System.ComponentModel.DataAnnotations;

namespace WebShopSeminar.Models.Dbo
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
