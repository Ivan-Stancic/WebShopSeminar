﻿using WebShopSeminar.Models.Base;

namespace WebShopSeminar.Models.Dbo
{
    public class ProductCategory : ProductCategoryBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
