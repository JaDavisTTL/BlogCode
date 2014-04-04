using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using Adminwebsite.localhost;


namespace AdminPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           

           Adminwebsite.localhost.BlogService Admin2webservice = new BlogService();

            ViewBag.Message = Admin2webservice.HelloBloggers();

            return View();
        }


    }
}
