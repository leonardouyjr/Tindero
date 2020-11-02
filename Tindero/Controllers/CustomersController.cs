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

       
    }
}