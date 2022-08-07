using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class FileStorage : FileStorageBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
