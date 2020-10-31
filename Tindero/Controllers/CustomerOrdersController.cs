using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tindero.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}