using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ViewResult Index()
        {
            meal m = new meal(2, "chix and Waffles");
           
            //passing the model into the view, we have to pass the model
            return View(m);
        }
    }
}