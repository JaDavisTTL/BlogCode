using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.Services.Description;
using Adminwebsite.localhost;
using Adminwebsite.service;


namespace AdminPage.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
           

        //   //Adminwebsite.service.BlogServiceClient admin2Webservice = new BlogServiceClient();

        //    //ViewBag.Message = admin2Webservice.HelloBloggers();

        //    return View();

   
        //}

        public ActionResult Index(string echoInput)
        {
            Adminwebsite.service.BlogServiceClient obj = new BlogServiceClient();   // Web Reference
            //Adminwebsite.localhost.BlogService obj = new BlogService();           // Service Reference
            if (echoInput == null)
            {
                return View();
            }
            else
            {
                ViewBag.message = obj.EchoUserInput(echoInput);
                return View();
            }
        }
    }
}
