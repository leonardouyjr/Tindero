using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int StockCount { get; set; }
    }
}