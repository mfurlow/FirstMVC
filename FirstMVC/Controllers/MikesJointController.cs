using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diner2;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class MikesJointController : Controller
    {

        public Restuarant MJoint = new Restuarant("Mike's Steak Joint",
            new Address("2543 Faust Ave", "Detroit", "MI", 48219), 
            new Menu(new List<IFoodItem>(new[] 
        {
            new FoodItem("Fire Ranch Mushroom Burger",10.1,Sizes.small),
            new FoodItem("Pork Ribs",25.2,Sizes.large),
            new FoodItem("Lamb",40.5,Sizes.xlarge)
        })
            ));
        // GET: MikesJoint
        public ViewResult Index()
        {
            ViewBag.someproperty = 1;
            ViewData["somekey"] = "some text";
           
            return View();
        }
        public ViewResult test()
        {
            return View();
        }
        public ViewResult Menu()
        {
            return View(MJoint);
        }

        [HttpGet]
        public ViewResult Order()
        {
            ViewData["Size"] = Enum.GetNames(typeof(Sizes)).ToList();
            ViewData["Menu"] = MJoint.OrderMenu.foodItemList;
            return View();
        }

        [HttpPost]
        public ViewResult Order(Cart cart)
        {
            
            return View("OrderResolved",cart);
        }

        

    }
}