using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerSite.CustomerWebservice;
using Microsoft.Ajax.Utilities;

namespace CustomerSite.Controllers
{
     
    public class HomeController : Controller
    {

        BlogService blogService = new BlogService();

        public ActionResult Index()
        {

            try
            {
                if (String.IsNullOrWhiteSpace(blogService.ReturnEntries()))
                {
                    return View();
                }
                else
                {
                    ViewBag.Message = blogService.ReturnEntries();
                }
            }
            catch (Exception e) //fix this properly later :P
            {
                ViewBag.Message = e.Message;
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

        public ActionResult NewPost(string newBlogEntry)
        {
            //var blogService = new BlogService();

            try
            {
                if (String.IsNullOrWhiteSpace(newBlogEntry))
                {
                    return View();
                }
                else
                {
                    blogService.PostNewEntry(newBlogEntry);
                    return RedirectToAction("Index");
                }
            }
            catch (WebException webException)
            {
                ViewBag.Message = "The web service could not be found: " + webException.Message + ".";
            }
            catch (Exception e)
            {
                ViewBag.Message = "Error: " + e.Message;
                Console.WriteLine(newBlogEntry);
            }
            return View();
        }


      
    }
}
