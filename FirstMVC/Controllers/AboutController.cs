using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diner2;

namespace FirstMVC.Controllers
{
    public class AboutController : Controller
    {
        private IMenu _menu;

        public AboutController(IMenu menu)
        {
            _menu = menu;
        }
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult DinerAddress()
        {
            var dinerAddress = (HttpContext.Application["Mjoint"] as Restuarant).Location;
            return PartialView(dinerAddress);
        }

        public PartialViewResult Menu()
        {
            //var dinermenu = (HttpContext.Application["frediner"] as Restaurant).OrderMenu.FoodItemList;
            var dinermenu = _menu.GetMenu();
            return PartialView(dinermenu);
        }

        [ChildActionOnly]
        [Obsolete(message: "example of passing data to partial view")]
        public PartialViewResult DinerAddressWithData(Address location)
        {
            return PartialView(location);
        }
    }
}