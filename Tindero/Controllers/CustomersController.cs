using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tindero.Models;
using Tindero.ViewModel;

namespace Tindero.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers        
        public ActionResult Show()
        {
            var customers = _context.Customers.ToList();            
            return View(customers);
        }

        public ActionResult ShowDetails(int id)
        {
            var customer = _context.Customers.Include(c => c.CustomerType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult New()
        {
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                CustomerTypes = _context.CustomerTypes.ToList()
            };

            return View("New", viewModel);
        }


        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));

                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    CustomerTypes = _context.CustomerTypes.ToList()
                };

                return View("New", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Show", "Customers"); //Go to index page to see the changes
            }
            else
            {
                var customerInDB = _context.Customers.Single(c => c.Id == customer.Id);

                if (customerInDB != null)
                {
                    // TryUpdateModel() can be used, but it is prone to security issues
                    // Only update what you need to update

                    customerInDB.FirstName = customer.FirstName;
                    customerInDB.LastName = customer.LastName;
                    customerInDB.Birthdate = customer.Birthdate;
                    customerInDB.CustomerTypeId = customer.CustomerTypeId;

                    _context.SaveChanges();
                    return RedirectToAction("Show", "Customers"); //Go to index page to see the changes

                }
                else
                {
                    return HttpNotFound();
                }
            }
        }
    }
}