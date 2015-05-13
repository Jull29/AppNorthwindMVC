using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppNorthwindMVC.Models;

namespace AppNorthwindMVC.Controllers
{
    public class ProductsController : Controller
    {
        private NORTHWNDEntities db = new NORTHWNDEntities();

        //
        // GET: /Products/

        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Categories).Include(p => p.Suppliers);
            return View(products.ToList());
        }

        //
        // GET: /Products/Details/5
        public ActionResult Search(string text)
        {
            var results = db.Products.Find(text);
            return PartialView("ResultsPartial", results);
        }

       

       
    }
}