using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tindero.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Customer's First Name is required.")]
        [StringLength(128)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Customer's Last Name is required.")]
        [StringLength(128)]
        public string LastName { get; set; }
        
        [Display(Name="Date of Birth") ]
        [Required(ErrorMessage = "Please Provide Birth Date")]
        public DateTime Birthdate { get; set; }
        
        public CustomerType CustomerType{get; set;}
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Please Select Customer Type")]
        public int CustomerTypeId { get; set; }
    }
}