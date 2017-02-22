using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Diner2;
using System.Web.Optimization;

namespace FirstMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        
        
        protected void Application_Start()
        {
            Application["Mjoint"] = new Restuarant("Mike's Steak Joint",
            new Address("2543 Faust Ave", "Detroit", "MI", 48219),
             new Menu(new List<IFoodItem>(new[] {
            new FoodItem("Fire Ranch Mushroom Burger",10.1,Sizes.small),
            new FoodItem("Pork Ribs",25.2,Sizes.large),
            new FoodItem("Lamb",40.5,Sizes.xlarge)
        })
            ));

        AreaRegistration.RegisterAllAreas();
          RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoConfig.RegisterDI();
        }
    }
}
