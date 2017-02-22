using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello Wrold";
        }
        public ViewResult SomeData()
        {
            ViewBag.text = "data";
            return View();
        }


    }
}