using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }

    }
}