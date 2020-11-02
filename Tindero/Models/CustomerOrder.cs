using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class CustomerOrder
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}