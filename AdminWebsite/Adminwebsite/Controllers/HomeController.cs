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
           

           Adminwebsite.localhost.BlogService admin2Webservice = new BlogService();

            ViewBag.Message = admin2Webservice.HelloBloggers();

            return View();
        }


    }
}
