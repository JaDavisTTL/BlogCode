using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerSite.CustomerWebservice;

namespace CustomerSite.Controllers
{
     
    public class HomeController : Controller
    {
       

        public ActionResult Index(string UserNameEcho)
        {
            var blogService = new BlogService();
         
            try
            {
                if (String.IsNullOrWhiteSpace(UserNameEcho))
                {
                    ViewBag.Message = "Please enter a username in the above field.";
                    return View();
                }
                else
                {
                    ViewBag.Message = blogService.ReplayUsername(UserNameEcho);
                    return View();
                }
            }
            catch (WebException webException)
            {
                ViewBag.Message = "The web service could not be found: " + webException.Message + ".";
            }
            catch (Exception e)
            {
                ViewBag.Message = "Error: " + e.Message + ".";
            }
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
