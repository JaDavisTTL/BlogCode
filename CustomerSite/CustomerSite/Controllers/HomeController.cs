using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerSite.CustomerWebservice;

namespace CustomerSite.Controllers
{
     
    public class HomeController : Controller
    {
       

        public ActionResult Index(string UserNameEcho)
        {
          CustomerWebservice.BlogService obj = new BlogService();

            if (UserNameEcho==null)
            {
              //  ViewBag.Message = "Please enter a username in the above field";
                return View();
            }
            else 
            {
                ViewBag.Message = obj.ReplayUsername(UserNameEcho);
                return View();
            }
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
