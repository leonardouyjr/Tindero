using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public int CostPrice { get; set; }
        [Required]
        public int SalePrice { get; set; }
        [Required]
        public int StockCount { get; set; }
        [Required]
        public int OrderCount { get; set; }
        [Required]
        public int ReorderLevel { get; set; }
        [Required]
        public bool Discountinued { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

    }
}