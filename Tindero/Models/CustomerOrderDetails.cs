using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class CustomerOrderDetails
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public CustomerOrder CustomerOrder { get; set; }
        public int CustomerOrderId { get; set; }


        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public byte RegularDiscount { get; set; }
        public byte SeniorCitizenDiscount { get; set; }

    }
}