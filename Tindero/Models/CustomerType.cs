using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace Tindero.Models
{
    public class CustomerType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}