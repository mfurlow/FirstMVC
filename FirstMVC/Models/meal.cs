using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMVC.Controllers;

namespace FirstMVC.Models
{
    public class meal
    {
        public int price = 10;
        public string food = "dumplings";

        public meal(int p, string f)
        {
            price = p;
            food = f;
        }
    }
}