using ASPMVCSampleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCSampleBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new AboutModel();
            model.AppTitle = "ASP.NET MVC Sample Blog";
            model.FrameworkVersion = "4.6";

            return View(model);
        }
    }
}