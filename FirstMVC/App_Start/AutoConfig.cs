using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Integration.Mvc;
using Autofac;
using System.Web.Mvc;
using Diner2;

namespace FirstMVC
{
    public class AutoConfig
    {
        public static void RegisterDI()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register dependencies
            builder.RegisterType<FoodItem>().As<IFoodItem>();
            builder.RegisterType<Menu>().As<IMenu>();


            // setup autofac as depencency resolver
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}