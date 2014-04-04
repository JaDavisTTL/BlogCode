using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerSite.CustomerWebservice;

namespace CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        CustomerWebservice.BlogService obj = new BlogService();


        public ActionResult Index()
        {
            //ViewBag.Message = "This page is for general users.  Cool features are coming soon! ;)";
            ViewBag.Message = obj.ReplayUsername("Maria");

            return View();
        }

      
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}
