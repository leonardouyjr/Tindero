using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tindero.Models;
using Tindero.ViewModel;

namespace Tindero.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id=1, FirstName = "Leonardo Jr.", LastName = "Uy", Birthdate = new DateTime(1978, 08, 24)},
                new Customer {Id=2, FirstName = "Mary Rose", LastName = "Uy", Birthdate =  new DateTime(1977, 04, 12)},
                new Customer {Id=3, FirstName = "Leonardo III", LastName = "Uy", Birthdate = new DateTime(2001, 10, 25)},
                new Customer {Id=4, FirstName = "Keyanna Gael", LastName = "Uy", Birthdate = new DateTime(2003, 06, 13)}
            };

            return customers;
        }
        public ActionResult Show()
        {
            var customer = GetCustomers();            
            return View(customer);
        }

        public ActionResult ShowDetails(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}