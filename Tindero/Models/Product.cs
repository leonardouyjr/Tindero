using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int StockCount { get; set; }
        public int OrderCount { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discountinued { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

    }
}