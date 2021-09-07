using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AffilateMarketingWeb.Models;
using System.IO;
using AffilateMarketingWeb.ViewModel;

namespace AffilateMarketingWeb.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            var catories = db.Categories;
            AllClassViewModel allClassViewModel = new AllClassViewModel
            {
                Products = products,
                Categories = catories
            };
            return View(allClassViewModel);
        }
        public ActionResult Selectedcategory(FormCollection form)
        {
            string id = Request.Form["id"];
            int CategoryId = Convert.ToInt32(id);
            var Products = db.Products.Where(t=>t.CategoryId==CategoryId);
            var catories = db.Categories;
            AllClassViewModel allClassViewModel = new AllClassViewModel
            {
                Products = Products,
                Categories = catories
            };
            return View("Index",allClassViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}