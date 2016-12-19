using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("List", "Article");
        }
    }
}