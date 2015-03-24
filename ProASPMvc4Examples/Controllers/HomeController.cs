using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
      Product myProduct = new Product { Name = "Biscuits", Categoty = "Food", Description = string.Empty, Price = 4.99m, ProductID = 1 };
        
      // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}