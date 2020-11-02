using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Tindero.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string ContactTitle { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(128)]
        public string Barangay { get; set; }

        [Required]
        [StringLength(128)]
        public string City { get; set; }

        [Required]
        [StringLength(128)]
        public string Country { get; set; }

        [Required]
        [StringLength(128)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(128)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(128)]
        public string WebsiteURL { get; set; }
    }
}