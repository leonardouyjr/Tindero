using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tindero.Models;

namespace Tindero.ViewModel
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<CustomerType> CustomerTypes { get; set; }
        
    }
}