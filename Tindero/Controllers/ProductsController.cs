using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tindero.Models;

namespace Tindero.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }

        public ActionResult ShowDetails(int id)
        {
            var product = GetProducts().SingleOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product {Id=1, Name = "Cheddar Ensaymada", CostPrice = 100, SalePrice = 130, OrderCount = 10, ReorderLevel = 50, StockCount = 70, Discountinued = false },
                new Product {Id=2, Name = "Parmesan Ensaymada", CostPrice = 110, SalePrice = 140, OrderCount = 20, ReorderLevel = 50, StockCount = 90, Discountinued = false },
                new Product {Id=3, Name = "Pork Floss Ensaymada", CostPrice = 120, SalePrice = 150, OrderCount = 15, ReorderLevel = 50, StockCount = 210, Discountinued = false },
                new Product {Id=4, Name = "Caramel Cake", CostPrice = 300, SalePrice = 650, OrderCount = 5, ReorderLevel = 5, StockCount = 10, Discountinued = false }
            };

            return products;
        }
    }
}