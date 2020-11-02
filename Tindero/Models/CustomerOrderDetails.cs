using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class CustomerOrderDetails
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public CustomerOrder CustomerOrder { get; set; }
        public int CustomerOrderId { get; set; }

        [Required]
        public int CostPrice { get; set; }
        [Required]
        public int SalePrice { get; set; }
        public byte RegularDiscount { get; set; }
        public byte SeniorCitizenDiscount { get; set; }

    }
}